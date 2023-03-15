Public Class clsMail
    Public bError As Boolean = False
 

    '###############################################################
    '# >> eMail Senden 
    '###############################################################
    Public Function setSendMail(ByVal strKundenemail As String, ByVal strContent As String, ByVal strBetreff As String) As Boolean
        Dim SmtpObj As New System.Net.Mail.SmtpClient
        Dim pop3Client As New OpenPop.Pop3.Pop3Client
        Try
            '# ->> Fehlerprüfung
            If strContent.Length = 0 Then
                MsgBox("Fehler kein inhalt")
                Return False
                Exit Function
            End If
            If strBetreff.Length = 0 Then
                MsgBox("Fehler kein Betrefftext")
                Return False
                Exit Function
            End If

            '# POP3 before SMTP nur dann ausführen wenn Setting vorliegt 
            If My.Settings.email_pop3_before_smtp(My.Settings.mandant_position) = "True" Then

                Try
                    pop3Client.Connect(My.Settings.email_pop3(My.Settings.mandant_position), My.Settings.email_pop_port(My.Settings.mandant_position), False)
                    pop3Client.Authenticate(My.Settings.email_username(My.Settings.mandant_position), My.Settings.email_pwd(My.Settings.mandant_position))
                Catch ex As Exception
                    MessageBox.Show("Fehler bei POP3: " & ex.Message, "Fehler bei POP3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If

            Dim MailNachricht As New System.Net.Mail.MailMessage()
            SmtpObj.UseDefaultCredentials = False
            SmtpObj.Credentials = New System.Net.NetworkCredential(My.Settings.email_username(My.Settings.mandant_position), My.Settings.email_pwd(My.Settings.mandant_position))
            SmtpObj.Port = My.Settings.email_smtp_port(My.Settings.mandant_position)

            'If My.Settings.email_istTestmodus = True Then
            ' strKundenemail = My.Settings.developer_email_check
            'End If

            SmtpObj.Host = My.Settings.email_smtp(My.Settings.mandant_position)  '"mail.gmx.net"

            If My.Settings.email_enable_ssl(My.Settings.mandant_position) = "True" Then
                SmtpObj.EnableSsl = True
            End If
            SmtpObj.Timeout = 5000
            SmtpObj.DeliveryMethod = Net.Mail.SmtpDeliveryMethod.Network
            'strKundenemail = "jbludau@cubss.net"
            With MailNachricht
                .From = New System.Net.Mail.MailAddress(My.Settings.email_username(My.Settings.mandant_position), My.Settings.email_absende_name(My.Settings.mandant_position))
                .BodyEncoding = System.Text.Encoding.UTF8
                .To.Add(strKundenemail)
                .Subject = strBetreff
                .IsBodyHtml = True  'My.Settings.email_isthtml
                .Body = strContent
            End With

            MailNachricht.Attachments.Clear()

            SmtpObj.Send(MailNachricht)

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler beim Email abschicken '" & strKundenemail & "'", MessageBoxButtons.OK, MessageBoxIcon.Error)
            bError = True
            Return False
        End Try

        Return True
    End Function
 
End Class
