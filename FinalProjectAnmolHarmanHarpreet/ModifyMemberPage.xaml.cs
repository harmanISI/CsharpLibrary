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
    public partial class ModifyMemberPage : Page
    {
        Object previousContent;
        LibraryMember toView;

        public ModifyMemberPage(Object _previousContent, LibraryMember _toView)
        {
            InitializeComponent();
            previousContent = _previousContent;
            toView = _toView;
            ModifyMember();
        }
        void ModifyMember()
        {
            ModifyNameBox.Text = toView.Name;
        }

        private void SubmitPage(object sender, RoutedEventArgs e)
        {
            String Modifyname = ModifyNameBox.Text;

            bool successFulRemove = Library.members.Remove((LibraryMember)toView);

            if (successFulRemove)
            {

                MessageBox.Show("You have successfully Updated  media item from the library");

                Library.members.Add(new LibraryMember(Modifyname));

                var backWindow = new MainWindow();
                backWindow.Show();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var backWindow = new MainWindow();

            backWindow.Show();
        }
    }
}
