using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskManagerApplication.Models;
using TaskManagerApplication.Models.Abstract;

namespace TaskManagerApplication
{
    /// <summary>
    /// Логика взаимодействия для DownloadPage.xaml
    /// </summary>
    public partial class DownloadPage : Page, MyPage
    {
        public DownloadPage()
        {
            InitializeComponent();
        }

        public PageInformation GetInformation()
        {
            return new DownloadPageInformation { Url = urlTextBox.Text, To = toTextBox.Text };
        }

        private void ToFindDirectoryButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                toTextBox.Text = dialog.FileName;
            }
        }
    }
}
