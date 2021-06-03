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

namespace FinalProjectAnmolHarmanHarpreet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediaDetailGrid.ItemsSource = Library.entries;
            libraryMemberGrid.ItemsSource = Library.members;

        }
        void RefreshDataGrid()
        {
            mediaDetailGrid.ItemsSource = null;
            mediaDetailGrid.ItemsSource = Library.entries;
            libraryMemberGrid.ItemsSource = Library.members;
        }
        private void modifyMemberBtn_Click(object sender, RoutedEventArgs e)
        {
            if (libraryMemberGrid.SelectedItem != null)
                this.Content = new ModifyMemberPage(this.Content, (LibraryMember)libraryMemberGrid.SelectedItem);
            else
                MessageBox.Show("You must select a library member  in order to access the modify member view.");


        }

        private void modifyMediaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mediaDetailGrid.SelectedItem != null)
                this.Content = new ModifyMediaPage(this.Content, (Media)mediaDetailGrid.SelectedItem);
            else
                MessageBox.Show("You must select a media item in order to access the modify media view.");
        }

        private void lendMediaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (libraryMemberGrid.SelectedItem != null && mediaDetailGrid.SelectedItem != null)
            {
                LibraryMember libraryMember = (LibraryMember)libraryMemberGrid.SelectedItem;
                Media media = (Media)mediaDetailGrid.SelectedItem;

                String selectedMember = libraryMember.Name;
                var selectedMedia = media.Title;
                String type = media.Type;
                int serialn0 = media.SerialNo;
                media.IsAvailable = false;

                MessageBox.Show("Media item: "+"'"+selectedMedia.ToString()+"'" + " lent out by: '" + selectedMember+"'.");
                bool successFulRemove = Library.entries.Remove((Media)mediaDetailGrid.SelectedItem);

                if (successFulRemove)
                {

                    MessageBox.Show("You have successfully lend a Media Item from the Library.");

                    Library.entries.Add(new Book(selectedMedia, type, 0, false, selectedMember, serialn0));
                    LibraryMember.currentlyBorrowed.Add(new Book(selectedMedia, type, 0, false, selectedMember, serialn0));
                    LibraryMember.borrowHistory.Add(new Book(selectedMedia, type, 0, false, selectedMember, serialn0));

                    RefreshDataGrid();
                }
                else
                    MessageBox.Show("You must select the media item from the data grid to lend it.");
                    RefreshDataGrid();
            }
            else {
                MessageBox.Show("You must select alleast one Member and Media Item from the data grid to lend it.");
            }
        }

        private void returnMediaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (libraryMemberGrid.SelectedItem != null && mediaDetailGrid.SelectedItem != null)
            {
                LibraryMember libraryMember = (LibraryMember)libraryMemberGrid.SelectedItem;
                Media media = (Media)mediaDetailGrid.SelectedItem;

                String selectedMember = libraryMember.Name;
                var selectedMedia = media.Title;
                String type = media.Type;
                int serialn0 = media.SerialNo;
                media.IsAvailable = true;

                MessageBox.Show("This Media Item: "+"'"+selectedMedia.ToString()+"'" + " Return out by: '"+ selectedMember+"'.");
                bool successFulRemove = Library.entries.Remove((Media)mediaDetailGrid.SelectedItem);

                if (successFulRemove)
                {

                    MessageBox.Show("You have successfully Return  the  media item from the library.");

                    Library.entries.Add(new Book(selectedMedia, type, 0, true, "", serialn0));
                    LibraryMember.currentlyBorrowed.Remove(new Book(selectedMedia, type, 0, true, selectedMember, serialn0));
                    RefreshDataGrid();
                }
                else
                    MessageBox.Show("You must select the media item from the data grid to Return Media it.");
                    RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("You must select Media Item that is lend out by any Member.");
            }
        }
        private void mediaInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mediaDetailGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select atleast one Media Item form the Media Grid.");
            }
            else { 
            Media media = (Media)mediaDetailGrid.SelectedItem;
            String selectedMedia = media.Title;
            MessageBox.Show(media.MediaInfo());
            }
        }
        private void memberInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (libraryMemberGrid.SelectedItem == null)
            {
                MessageBox.Show("Please select atleast one Member form the Member Grid.");
            }
            else
            {
                LibraryMember libraryMember = (LibraryMember)libraryMemberGrid.SelectedItem;
                String selectedMember = libraryMember.Name;
                libraryMember.MemberInfo(selectedMember);
                MessageBox.Show(libraryMember.MemberInfo(selectedMember));
            }
        }
    }
}
