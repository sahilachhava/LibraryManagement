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
    public partial class MediaDetails : Page
    {
        Object mainContent;
        Media currentMedia;
        public MediaDetails(Object _mainContent, Media _currentMedia)
        {
            InitializeComponent();
            mediaTypeComboBox.ItemsSource = (typeof(MediaType)).GetEnumValues();
            mainContent = _mainContent;
            currentMedia = _currentMedia;
            mediaTitle.Text = currentMedia.MediaTitle;
            mediaTypeComboBox.SelectedItem = currentMedia.MediaType;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = mainContent;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            if(mediaTitle.Text == "" || mediaTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please enter valid details to update");
            }
            else
            {
                currentMedia.MediaTitle = mediaTitle.Text;
                currentMedia.MediaType = (MediaType)mediaTypeComboBox.SelectedItem;
                MessageBox.Show("Media Details Updated Successfully");
                Application.Current.MainWindow.Content = mainContent;
            }
        }
    }
}
