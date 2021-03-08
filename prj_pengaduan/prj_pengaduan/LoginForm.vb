Public Class LoginForm
    Dim cek As Integer
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click
        If user.Text = "admin" Then

            If pass.Text = "password" Then
                frmmenu.Show()
                Me.Hide()
            Else
                cek = cek + 1
                MsgBox("Mohon cek kembali Password", MsgBoxStyle.Information, "Peringatan")
                pass.Text = ""
                pass.Focus()
                If cek > 3 Then
                    MsgBox("Anda sudah salah memasukkan Password 3 kali, Mohon berhati-hati!", MsgBoxStyle.Exclamation, "Peringatan Keras")
                    cek = 0
                End If
            End If

        Else
            MsgBox("Mohon cek kembali Username", MsgBoxStyle.Information, "Peringatan")
            user.Text = ""
            user.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
