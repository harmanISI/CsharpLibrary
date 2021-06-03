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
    /// Interaction logic for ModifyMediaPage.xaml
    /// </summary>
    public partial class ModifyMediaPage : Page
    {
        Object previousContent;
        Media toView;
        public ModifyMediaPage(Object _previousContent, Media _toView)
        {
            InitializeComponent();
            previousContent = _previousContent;
            toView = _toView;
            ModifyMedia();
        }
        void ModifyMedia()
        {
            ModifyTextBox.Text = toView.Title;
            ModifyTypeBox.Text = toView.Type;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            String Modifyname = ModifyTextBox.Text;

            String type = toView.Type;
            int serialn0 = toView.SerialNo;
            bool isavailable = toView.IsAvailable;
            String borower = toView.Borrower;


            bool successFulRemove = Library.entries.Remove((Media)toView);

            if (successFulRemove)
            {

                MessageBox.Show("You have successfully Updated  media item from the library");

                Library.entries.Add(new Book(Modifyname, type, 0, isavailable, borower, serialn0));

                var backWindow = new MainWindow();
                backWindow.Show();



            }


        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // Application.Current.MainWindow.Content = previousContent;

            /*  var backWindow = new MainWindow();
              backWindow.Show();*/
            //backWindow.DataContext = new ModifyMemberPage();

        }
    }
}
