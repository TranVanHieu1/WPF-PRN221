using Candidate_BusinessObject;
using Candidate_Service;
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

namespace Candidate_WPF_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IHRAccountService iAccount;
        public MainWindow()
        {
            InitializeComponent();
            iAccount = new HRAccountService();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Hraccount account = iAccount.GetHraccountByEmail(txtEmail.Text);

            if (account != null && txtPassword.Password.Equals(account.Password) && account.MemberRole == 1)
            {
                JobPostingWindow jobPostingWindow = new JobPostingWindow();
                jobPostingWindow.Show();
               
            }
            else
            {
                CandidateProfileWindow profileWindow = new CandidateProfileWindow();
                profileWindow.Show();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}