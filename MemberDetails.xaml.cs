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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MemberDetails.xaml
    /// </summary>
    public partial class MemberDetails : Page
    {
        Object mainContent;
        LibraryMember member;
        public MemberDetails(Object _mainContent, LibraryMember _member)
        {
            InitializeComponent();
            mainContent = _mainContent;
            member = _member;
            memberName.Text = member.MemberName;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = mainContent;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            if(memberName.Text == "")
            {
                MessageBox.Show("Please enter valid member name to update");
            }
            else
            {
                member.MemberName = memberName.Text;
                MessageBox.Show("Member Name updated successfully");
                Application.Current.MainWindow.Content = mainContent;
            }
        }
    }
}
