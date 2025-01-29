using System.IO;
using System.Net;
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

namespace WpfApp57_Asyncronous_programming
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //e.g.1 with syncronous
            //DownloadHtml("http://msdn.microsoft.com");  //leave this when you want to puch the button syncronous and the UI will freeze until the download of url is completed

            //e.g.2 with asyncronous when we return async method void that returns nothing, so we need to use the normal Task
            //DownloadHtmlAsync("http://msdn.microsoft.com"); //is active this line because will use the asyncronous method when we push the button
                                                               //so after click on button, the UI will not freeze and we can move, resize, .. while the download of url is done
            //e.g.3 with syncronous
            //var html = GetHtml("http://msdn.microsoft.com");
            //MessageBox.Show(html.Substring(0, 10));

            //e.g.4 with asyncronous when we return async method that return a string, so we need to use the generic Task<string>
            var html = await GetHtmlAsync("http://msdn.microsoft.com");  //<<-- only for this e.g.4 we need to make the method Button_Click() as async because
                                                                         //we can only use the await operator in a async method 
            MessageBox.Show(html.Substring(0, 10));

            //e.g.5 which is exactly as e.g.4 but we write the code so that we can do other stuff while the download operation is in progress, like display a
            //message to the user
            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com"); //we changed this, we removed the "await", so it is no longer asyncronous here !!!!
            MessageBox.Show("Waiting for the task to complete."); // <<<--- this is an example of some code we can execute while the asyncronous 
                                                                  //operation "getHtmlTask" is saved in var html2
                                                                  //we could do more things here ... depending what we want to do .....so some work that
                                                                  //is not dependent of the outcome of the asyncronous operation
            var html2 = await getHtmlTask; //we moved the "await" here, so actually we made the asyncronous to be here now !!!!
                                             //this just says to runtime that the rest of the code below cannot be executed until the operation "getHtmlTask" is completed
            MessageBox.Show(html.Substring(0, 10));
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            return await webClient.DownloadStringTaskAsync(url); //this method returns a Task<string>
                                                                 //is another asyncronous method
        }

        public string GetHtml(string url) //this is the method that is suncronous
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }

        public async Task DownloadHtmlAsync(string url) //this is the method that is asyncronous
                                                        //THIS METHOD RETURNS VOID, so i need to use the normal Task here !!!!!
                                                        //name convention for Task is to add "Async" at the end
                                                        //the method needs to have "async" when we declare it
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url); //this is the blocking operation DownloadString(url) that we need to do asyncronous
                                                      //pretty much all blocking operation has a syncronous and asyncronous variant, so we need to choose the one with "Async" at the end in its name
                                                      //when we call an asyncronous method that returns a Task we need to add the "await" keyword
            using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
            {
                await streamWriter.WriteAsync(html);  //this is the blocking operation Write(html) that we need to do asyncronous
            }
        }

        public void DownloadHtml(string url) //this is the method that is syncronous
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\projects\result.html")) //it will download the html of the url and save it in this file on hard disk
            {
                streamWriter.Write(html);
            }
        }
    }
}