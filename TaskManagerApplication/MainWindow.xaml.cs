using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
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
        private List<Timer> timers = new List<Timer>();
        private TypeOfRepetitions typeOfRepetitions;

        public MainWindow()
        {
            InitializeComponent();
            typeOfRepetitions = TypeOfRepetitions.None;
            frame.Content = new BasePage();
        }

        private void SendEmail(object emailPageInformation)
        {
            var info = emailPageInformation as EmailPageInformation;
            string toEmail = info.Recipient;
            string header = info.Header;
            string body = info.Body;

            SmtpClient client = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
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
            WindowState = WindowState.Minimized;
            ShowInTaskbar = false;
            e.Cancel = true;
        }

        private void EmailMenuItemClick(object sender, RoutedEventArgs e)
        {
            selectTypeMenuItem.Header = "Email message";
            frame.Content = new EmailPage();
        }


        private void DownloadFile(object info)
        {
            var information = info as DownloadPageInformation;
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(
                    new Uri(information.Url),
                    information.To
                );
            }
        }

        private void MoveFile(object info)
        {
            var information = info as MoveDirectoryPageInformation;
            try
            {
                if (Directory.Exists(information.From))
                {
                    if (Directory.Exists(information.To))
                    {
                        //Directory.Delete(information.To);
                        Directory.Move(information.To, DateTime.Now.ToString("_MMMdd_yyyy_HHmmss"));
                        Directory.Move(information.From, information.To);
                    }
                    else
                    {
                        Directory.Move(information.From, information.To);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void NextButtonClick(object sender, RoutedEventArgs e)
        {
            ActionInfo actionInfo = new ActionInfo();
            DateTime dateTime;
            try
            {
                var date = Convert.ToDateTime(datePicker.ToString());
                var time = timePicker.SelectedTime;
                dateTime = new DateTime(date.Year, date.Month, date.Day, time.Value.Hour, time.Value.Minute, 0);

            }
            catch (Exception)
            {
                MessageBox.Show("Select date and time!");
                return;
            }
            actionInfo.StartDate = dateTime;

            if (typeOfRepetitions == TypeOfRepetitions.None)
            {
                MessageBox.Show("Select periodicity!");
                return;
            }
            actionInfo.Pereodicity = typeOfRepetitions;

            int pulseHours = 0;

            switch (typeOfRepetitions)
            {
                case TypeOfRepetitions.OneTime:
                    pulseHours = 0;
                    break;
                case TypeOfRepetitions.OnceADay:
                    pulseHours = 24;
                    break;
                case TypeOfRepetitions.OnceAWeek:
                    pulseHours = 168;
                    break;
                case TypeOfRepetitions.OnceAMounth:
                    pulseHours = 730;
                    break;
                case TypeOfRepetitions.OnceAYear:
                    pulseHours = 8760;
                    break;
            }

            switch (selectTypeMenuItem.Header)
            {
                case "Email message":
                    EmailPageInformation emailPageInformation = (frame.Content as MyPage).GetInformation() as EmailPageInformation;

                    actionInfo.Type = Models.Type.Email;

                    timers.Add(new Timer(SendEmail, emailPageInformation, TimeSpan.FromHours(0), TimeSpan.FromHours(pulseHours)));

                    break;

                case "Download file":
                    DownloadPageInformation downloadPageInformation = (frame.Content as MyPage).GetInformation() as DownloadPageInformation;

                    actionInfo.Type = Models.Type.Download;

                    timers.Add(new Timer(DownloadFile, downloadPageInformation, TimeSpan.FromHours(0), TimeSpan.FromHours(pulseHours)));

                    break;

                case "Move directory":
                    MoveDirectoryPageInformation moveDirectoryPageInformation = (frame.Content as MyPage).GetInformation() as MoveDirectoryPageInformation;
                    
                    actionInfo.Type = Models.Type.MoveDirectiory;

                    timers.Add(new Timer(MoveFile, moveDirectoryPageInformation, TimeSpan.FromHours(0), TimeSpan.FromHours(pulseHours)));

                    break;
                default:
                    MessageBox.Show("Select type!");
                    return;
            }
        }

        private void OneTimeMenuItemClick(object sender, RoutedEventArgs e)
        {
            typeOfRepetitions = TypeOfRepetitions.OneTime;

            periodicityMenuItem.Header = "One time";

        }

        private void OnceADayMenuItemClick(object sender, RoutedEventArgs e)
        {
            typeOfRepetitions = TypeOfRepetitions.OnceADay;

            periodicityMenuItem.Header = "Once a day";
        }

        private void OnceAWeekMenuItemClick(object sender, RoutedEventArgs e)
        {
            typeOfRepetitions = TypeOfRepetitions.OnceAWeek;

            periodicityMenuItem.Header = "Once a week";
        }

        private void OnceAMounthMenuItemClick(object sender, RoutedEventArgs e)
        {
            typeOfRepetitions = TypeOfRepetitions.OnceAMounth;

            periodicityMenuItem.Header = "Once a mounth";
        }

        private void OnceAYearMenuItemClick(object sender, RoutedEventArgs e)
        {
            typeOfRepetitions = TypeOfRepetitions.OnceAYear;

            periodicityMenuItem.Header = "Once a year";
        }

        private void MoveDirectoryMenuItemClick(object sender, RoutedEventArgs e)
        {
            selectTypeMenuItem.Header = "Move directory";
            frame.Content = new MoveDirectoryPage();
        }

        private void DownloadMenuItemClick(object sender, RoutedEventArgs e)
        {
            selectTypeMenuItem.Header = "Download file";
            frame.Content = new DownloadPage();
        }
    }
}
