//
// Copyright © 2018 Ranorex All rights reserved
//

using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace Ranorex.AutomationHelpers.UserCodeCollections
{
    /// <summary>
    /// Used to send emails from a recording or module.
    /// </summary>
    [UserCodeCollection]
    public static class EmailLibrary
    {
        private const string libraryName = "EmailLibrary";

        /// <summary>
        /// Sends an email.
        /// </summary>
        /// <param name="subject">Email subject</param>
        /// <param name="to">Email recipients, separated by comma or semicolon</param>
        /// <param name="from">Email sender</param>
        /// <param name="body">Email message</param>
        /// <param name="attachment">Path of a file to attach</param>
        /// <param name="serverHostname">Server hostname</param>
        /// <param name="serverPort">Server port</param>
        /// <param name="useSSL">Defines whether SSL is used or not (true or false)</param>
        /// <param name="emailUsername">emailUsername</param>
        /// <param name="emailPassword">emailPassword</param>
        /// <param name="domain">domain</param>
        [UserCodeMethod]
         public static void SendEmail(string subject, string to, string from, string body,string[] attachment,string serverHostname, int serverPort, bool useSSL, string emailUsername, string emailPassword, string domain)
		{
    			SmtpClient client = new SmtpClient(serverHostname, serverPort);
    			client.TargetName="STARTTLS/smtp.office365.com";
    			client.UseDefaultCredentials = false; // Ensure not to use default credentials
    			client.Credentials = new NetworkCredential(emailUsername, emailPassword, domain);
    			client.EnableSsl = true; // Ensure this is set to true if SSL/TLS is required
    			
                //client.TargetName="STARTTLS/smtp.office365.com";
    			MailMessage mailMessage = new MailMessage(from, to, subject, body);
    			

               // Attach each report file
        if (attachment != null && attachment.Length > 0)
        {
            foreach (string reportFile in attachment)
            {
                if (!string.IsNullOrEmpty(reportFile))
                {
                    Attachment attachment1 = new Attachment(reportFile);
                    mailMessage.Attachments.Add(attachment1);
                }
            }
        }
    	// Send email
    	try
    	{
    		
    		client.Send(mailMessage);
        		
        		Report.Info("Email sent successfully.");
    	}
    catch (SmtpException smtpEx)
	{
    	Report.Info($"SMTP Exception: {smtpEx.Message}");
    // Log smtpEx.StackTrace if you need additional debugging information
	}
    	catch (Exception ex)
    	{
        		Report.Info($"Failed to send email: {ex.Message}");
        		throw;
        // Handle exception as needed
    	}
    	finally
	{
    // Dispose of resources
   	 mailMessage.Dispose();
	}
   }
  }
}       

