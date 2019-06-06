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
    public partial class MoveDirectoryPage : Page, MyPage
    {
        public MoveDirectoryPage()
        {
            InitializeComponent();
        }

        public PageInformation GetInformation()
        {
            return new MoveDirectoryPageInformation
            {
                From = fromTextBox.Text,
                To = toTextBox.Text
            };
        }

        private void FromFindDirectoryButtonClick(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                fromTextBox.Text = folderDialog.SelectedPath.ToString();
            }
        }

        private void ToFindDirectoryButtonClick(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                toTextBox.Text = folderDialog.SelectedPath.ToString();
            }
        }
    }
}
