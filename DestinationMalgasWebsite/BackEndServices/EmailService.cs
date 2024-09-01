namespace DestinationMalgasWebsite.BackEndServices
{
    using EASendMail;

    namespace Prog7311_POE_ST10071737.Services
    {
        public class EmailService
        {
            private string senderEmail = "destinationmalgasdev1@gmail.com";
            private string senderPassword = "ruputpehevakhfmm";
            private string recieverEmail = "twan@destinationmalgas.co.za";


            public string subject { get; set; } = "";
            public string body { get; set; } = "";
            public string email { get; set; } = "";
            public string phoneNumber { get; set; } = "";
            public string name { get; set; } = "";
            public string arrivalDate { get; set; } = "";
            public string departureDate { get; set; } = "";
            public int adults { get; set; } = 0;
            public int kids { get; set; } = 0;
            public string HouseName { get; set; } = "";
            public string comments { get; set; } = "";


            public void CantactpageSender()
            {
                try
                {
                    string constructedBody = "Hi my name is " + this.name +
                        "\r\n" +
                        "\r\nPlease contact me from this Email: " + this.email +
                        "\r\nOr this Phone number: " + this.phoneNumber + 
                        "\r\n" + 
                        "\r\n" + body;

                    SmtpMail oMail = new SmtpMail("TryIt");

                    // Your gmail email address
                    oMail.From = senderEmail;
                    // Set recipient email address
                    oMail.To = recieverEmail;

                    // Set email subject
                    oMail.Subject = subject;
                    // Set email body
                    oMail.TextBody = constructedBody;

                    // Gmail SMTP server address
                    SmtpServer oServer = new SmtpServer("smtp.gmail.com");
                    // Gmail user authentication
                    // For example: your email is "gmailid@gmail.com", then the user should be the same
                    oServer.User = senderEmail;

                    // Create app password in Google account
                    // https://support.google.com/accounts/answer/185833?hl=en
                    oServer.Password = senderPassword;

                    // Set 587 port, if you want to use 25 port, please change 587 5o 25
                    oServer.Port = 465;

                    // detect SSL/TLS automatically
                    oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                    //Console.WriteLine("start to send email over SSL ...");

                    SmtpClient oSmtp = new SmtpClient();
                    oSmtp.SendMail(oServer, oMail);

                    //Console.WriteLine("email was sent successfully!");
                }
                catch (Exception ep)
                {
                    //Console.WriteLine("failed to send email with the following error:");
                    //Console.WriteLine(ep.Message);
                }
            }

            public void AccomadationpageSender()
            {
                try
                {
                    string AccSubject = this.HouseName + " inquiry for " + this.arrivalDate +" - " + this.departureDate;

                    string constructedBody = 
                            "Hi my name is " + this.name +
                        "\r\n" +
                        "\r\nPlease contact me from this Email: " + this.email +
                        "\r\nOr this Phone number: " + this.phoneNumber +
                        "\r\n" +
                        "\r\nHello, my name is  " + this.name + " and i would like to book the " +this.HouseName + " for " + this.arrivalDate + " till " + this.departureDate +
                        "\r\nWe will be " + adults + " adults and " + kids + " kids" +
                        "\r\n" +
                        "\r\n" + comments;

                    SmtpMail oMail = new SmtpMail("TryIt");

                    // Your gmail email address
                    oMail.From = senderEmail;
                    // Set recipient email address
                    oMail.To = recieverEmail;

                    // Set email subject
                    oMail.Subject = AccSubject;
                    // Set email body
                    oMail.TextBody = constructedBody;

                    // Gmail SMTP server address
                    SmtpServer oServer = new SmtpServer("smtp.gmail.com");
                    // Gmail user authentication
                    // For example: your email is "gmailid@gmail.com", then the user should be the same
                    oServer.User = senderEmail;

                    // Create app password in Google account
                    // https://support.google.com/accounts/answer/185833?hl=en
                    oServer.Password = senderPassword;

                    // Set 587 port, if you want to use 25 port, please change 587 5o 25
                    oServer.Port = 465;

                    // detect SSL/TLS automatically
                    oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                    //Console.WriteLine("start to send email over SSL ...");

                    SmtpClient oSmtp = new SmtpClient();
                    oSmtp.SendMail(oServer, oMail);

                    //Console.WriteLine("email was sent successfully!");
                }
                catch (Exception ep)
                {
                    //Console.WriteLine("failed to send email with the following error:");
                    //Console.WriteLine(ep.Message);
                }
            }

        }
    }

}
