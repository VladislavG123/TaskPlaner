using System;
using System.Collections.Generic;
using System.Linq;
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
using TaskManagerApplication.Models.Abstract;

namespace TaskManagerApplication
{
    public partial class EmailPage : Page, MyPage
    {
        public EmailPage()
        {
            InitializeComponent();
        }

        public PageInformation GetInformation()
        {
            return new EmailPageInformation
            {
                Recipient = recipientTextBox.Text,
                Header = headerTextBox.Text,
                Body = new TextRange(bodyRichBox.Document.ContentStart, bodyRichBox.Document.ContentEnd).Text
            };
        }
    }
}
