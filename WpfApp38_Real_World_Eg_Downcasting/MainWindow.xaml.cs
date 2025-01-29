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

namespace WpfApp38_Real_World_Eg_Downcasting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //E.g. of downcasting when we know for sure the conversion will be successful :
            var button = (Button)sender;
            //button. <<-- only after downcasting the object sender to derived class Button , i will have access to all the properties defined in Button class
            //this is a real world e.g. when we need to downcast object sender

            MessageBox.Show("Hello World!");

            //E.g. of downcasting when we use the "as" keyword since we are not sure the conversion will be ok so might get InvalidCastException
            var button2 = sender as Button;
            if (button != null)
            {
                //here conversion was successful so we do what we want with the button .....
                MessageBox.Show(button.ActualHeight.ToString());
            }

            MessageBox.Show("Hello World!");
        }
    }
}