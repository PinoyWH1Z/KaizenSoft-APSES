Imports System.Net.Mail
Public Class a
    Private Sub lX(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "KaizenSoft - Anonymous Portable Simple eMail Sender [v2]"
    End Sub

    Private Sub sX(sender As Object, e As EventArgs) Handles s.Click
        Try
            Dim smtps As New SmtpClient
            Dim email As New MailMessage()
            smtps.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
            smtps.UseDefaultCredentials = False
            smtps.Credentials = New Net.NetworkCredential("user@domain.com", "password")
            smtps.Port = 587
            smtps.EnableSsl = True
            smtps.Host = "smtp.domain.com"
            email = New MailMessage()
            email.From = New MailAddress("user@domain.com")
            email.To.Add(t1.Text)
            email.Subject = t2.Text
            email.IsBodyHtml = False
            email.Body = t3.Text
            smtps.Send(email)
            MsgBox("The email has been sent.")
        Catch err As Exception
            MsgBox(err.ToString)
        End Try
    End Sub

    Private Sub lD_Click(sender As Object, e As EventArgs) Handles lD.Click
        MessageBox.Show("KaizenSoft APSES v2" & Environment.NewLine & "(Anonymous Portable Simple eMail Sender)" & Environment.NewLine & "An open-source project by:" & Environment.NewLine & "KaizenLouie (https://github.com/kaizenlouie)")
    End Sub
End Class
