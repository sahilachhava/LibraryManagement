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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MediaList.ItemsSource = Library.allMedia;
            MemberList.ItemsSource = Library.allMembers;
        }

        private void BorrowBtn_Click(object sender, RoutedEventArgs e)
        {
            Media currentMedia = (Media)MediaList.SelectedItem;
            LibraryMember borrower = (LibraryMember)MemberList.SelectedItem;
            if (currentMedia != null && borrower != null)
            {
                if (currentMedia.IsBorrowed)
                {
                    MessageBox.Show("Selected Media is already borrowed!");
                    return;
                }
                else
                {
                    currentMedia.IsBorrowed = true;
                    currentMedia.NoOfTimeLent += 1;
                    currentMedia.CurrentBorrower = borrower.MemberName;
                    borrower.currentlyBorrowed.Add(currentMedia);
                    RefreshMedia();
                    MessageBox.Show("Media borrowed successfully");
                }
            }
            else
            {
                MessageBox.Show("Please select Media and Member to borrow!");
                return;
            }
        }

        public void RefreshMedia()
        {
            MediaList.ItemsSource = null;
            MediaList.ItemsSource = Library.allMedia;
        }

        private void ReturnBtn_Click(object sender, RoutedEventArgs e)
        {
            Media currentMedia = (Media)MediaList.SelectedItem;
            if(currentMedia != null && currentMedia.IsBorrowed)
            {
                foreach(LibraryMember member in Library.allMembers)
                {
                    if (member.MemberName == currentMedia.CurrentBorrower)
                    {
                        member.currentlyBorrowed.Remove(currentMedia);
                        member.borrowHistory.Add(currentMedia);
                        break;
                    }
                }
                currentMedia.IsBorrowed = false;
                currentMedia.CurrentBorrower = null;
                RefreshMedia();
                MessageBox.Show("Media returned successfully");
            }
            else
            {
                MessageBox.Show("Please Select Borrowed Media or Selected Media is not borrowed!");
            }
        }

        private void modifyBtn_Click(object sender, RoutedEventArgs e)
        {
            Media currentMedia = (Media)MediaList.SelectedItem;
            if(currentMedia != null)
            {
                this.Content = new MediaDetails(this.Content, currentMedia);
                RefreshMedia();
            }
            else
            {
                MessageBox.Show("Please Select Media to Modify!");
            }
        }

        private void modifyMember_Click(object sender, RoutedEventArgs e)
        {
            LibraryMember member = (LibraryMember)MemberList.SelectedItem;
            if(member == null)
            {
                MessageBox.Show("Please Select Member to Modify!");
            }
            else
            {
                this.Content = new MemberDetails(this.Content, member);
                MemberList.ItemsSource = null;
                MemberList.ItemsSource = Library.allMembers;
            }
        }

        private void displayMedia_Click(object sender, RoutedEventArgs e)
        {
            Media currentMedia = (Media)MediaList.SelectedItem;
            if (currentMedia != null)
            {
                MessageBox.Show(currentMedia.MediaInfo());
            }
            else
            {
                MessageBox.Show("Please Select Media for Display!");
            }
        }

        private void displayMember_Click(object sender, RoutedEventArgs e)
        {
            LibraryMember member = (LibraryMember)MemberList.SelectedItem;
            if (member == null)
            {
                MessageBox.Show("Please Select Member for Display!");
            }
            else
            {
                MessageBox.Show(member.MemberInfo());
            }
        }
    }
}
