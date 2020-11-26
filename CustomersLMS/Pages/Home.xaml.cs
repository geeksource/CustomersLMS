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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        private SshClient sshClient = null;
        public Home(SshClient _sshClient)
        {
            InitializeComponent();
            sshClient = _sshClient;
        }

        private void BtnExecute_Click(object sender, RoutedEventArgs e)
        {
            using (var cmd = sshClient.CreateCommand(txtCommand.Text))
            {
                cmd.Execute();
                commandOutputArea.AppendText(cmd.Result);
                Console.WriteLine("Command>" + cmd.CommandText);
                Console.WriteLine("Return Value = {0}", cmd.ExitStatus);
            }
        }
    }
}
