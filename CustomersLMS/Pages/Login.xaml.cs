using Renci.SshNet;
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

namespace CustomersLMS.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private SshClient sshClient = null;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string IPAddress = txtIPAddress.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;
            try
            {
                sshClient = new SshClient(IPAddress, UserName, Password);
                sshClient.Connect();
                this.NavigationService.Navigate(new Home(sshClient));
                //using (var client = new SshClient("sftp.foo.com", "guest", "pwd"))
                //{                
                //    client.Connect();
                //}
            }
            catch (Exception ex)
            {

            }

        }
    }
}
