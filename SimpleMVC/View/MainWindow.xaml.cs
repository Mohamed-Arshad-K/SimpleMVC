using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleMVC.Controller;

namespace SimpleMVC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        NameController _controller = null;

        public MainWindow()
        {
            InitializeComponent();
            _controller = new NameController(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NameController controller = new NameController();

            ///Data from View Sent to Controller
            ///Inside the controller data is sent to Model
            controller.SetFullName(fName.Text, sName.Text);

            ///View Query the Controller for the Model
            controller.Display();

            controller.Close(this);
        }
    }
}