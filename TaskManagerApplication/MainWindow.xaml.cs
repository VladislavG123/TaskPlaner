using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskManagerApplication.Models;

namespace TaskManagerApplication
{
    public partial class MainWindow : Window
    {
        private string password = "8W8_55Vlad";

        public MainWindow()
        {
            InitializeComponent();
            frame.Content = new BasePage();
        }

        private void SendEmail(string toEmail, string header, string body)
        {
            SmtpClient client = new SmtpClient
            {
                Port = 587,
                Host = "smtp.mail.ru",
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("gvo_step2018@mail.ru", password)
            };
            MailMessage mailMessage = new MailMessage("gvo_step2018@mail.ru", toEmail, header, body)
            {
                BodyEncoding = Encoding.UTF8,
                DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            };

            client.Send(mailMessage);
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void EmailMenuItemClick(object sender, RoutedEventArgs e)
        {
            selectTypeMenuItem.Header = "Email message";
            frame.Content = new EmailPage();
        }

        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            switch (selectTypeMenuItem.Header)
            {
                case "Email message":

                    EmailPageInformation emailPageInformation = (frame.Content as MyPage).GetInformation() as EmailPageInformation;

                    var date = Convert.ToDateTime(datePicker.ToString()).ToString("dd.MM.yyyy");
                    var time = timePicker.SelectedTime.ToString();

                    SendEmail(emailPageInformation.Recipient, emailPageInformation.Header + date + time, emailPageInformation.Body);


                    break;
            }
        }
    }
}
