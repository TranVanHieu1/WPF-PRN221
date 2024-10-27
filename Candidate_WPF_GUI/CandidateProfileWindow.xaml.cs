using Candidate_BusinessObject;
using Candidate_Service;
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
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Candidate_WPF_GUI
{
    /// <summary>
    /// Interaction logic for CandidateProfileWindow.xaml
    /// </summary>
    public partial class CandidateProfileWindow : Window
    {

        private ProfileService profileService;
        private JobPostingService jobPostingService;

        public CandidateProfileWindow()
        {
            InitializeComponent();
            profileService = new ProfileService();
            jobPostingService = new JobPostingService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LoadInitData();
            
        }

        private void LoadInitData()
        {
            dtgProfile.ItemsSource = profileService.GetCandidateProfiles();
            cbJobPosting.ItemsSource = jobPostingService.GetJobPostings();
            cbJobPosting.DisplayMemberPath = "JobPostingTitle";
            cbJobPosting.SelectedValuePath = "PostingId";
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile profile = new CandidateProfile();
            profile.CandidateId = txtPostID.Text;
            profile.Fullname = txtFullName.Text;
            profile.ProfileShortDescription = txtDescription.Text;
            profile.ProfileUrl = txtImageURL.Text;
            profile.Birthday = DateTime.Parse(dtgBirthDay.Text);
            // Retrieve the selected JobPosting from the ComboBox
            JobPosting selectedJobPosting = cbJobPosting.SelectedItem as JobPosting;

            // Check if a job posting is selected
            if (selectedJobPosting != null)
            {
                profile.PostingId = selectedJobPosting.PostingId; // Set PostingId to the selected job posting
            }
            else
            {
                MessageBox.Show("Please select a job posting.");
                return; // Exit if no job posting is selected
            }

            if (profileService.AddPrifile(profile))
            {
                MessageBox.Show("Add successful!!");
                dtgProfile.ItemsSource = profileService.GetCandidateProfiles();
                dtgProfile.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Something wrong!");
            }
        }


        private void dtgProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator
                .ContainerFromIndex(dataGrid.SelectedIndex);

            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;

            string id = ((TextBlock)RowColumn.Content).Text;
            CandidateProfile jobPosting = profileService.GetProfile(id);

            txtPostID.Text = jobPosting.CandidateId.ToString();
            txtFullName.Text = jobPosting.Fullname.ToString();
            txtImageURL.Text = jobPosting.ProfileUrl.ToString();
            dtgBirthDay.Text = jobPosting.Birthday.ToString();
            cbJobPosting.Text = jobPosting.PostingId.ToString();
            txtDescription.Text = jobPosting.ProfileShortDescription.ToString();
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            CandidateProfile jobPosting = profileService.GetProfile(txtPostID.Text);

            if (jobPosting != null)
            {
                jobPosting.Fullname = txtFullName.Text;
                jobPosting.ProfileUrl = txtImageURL.Text;
                jobPosting.Birthday = DateTime.Parse(dtgBirthDay.Text);
                jobPosting.ProfileShortDescription = txtDescription.Text;
                JobPosting selectedJobPosting = cbJobPosting.SelectedItem as JobPosting;

                // Check if a job posting is selected
                if (selectedJobPosting != null)
                {
                    jobPosting.PostingId = selectedJobPosting.PostingId; // Set PostingId to the selected job posting
                }
                else
                {
                    MessageBox.Show("Please select a job posting.");
                    return; // Exit if no job posting is selected
                }
                if (profileService.UpdateProfile(jobPosting))
                {
                    MessageBox.Show("Update Successful!");
                    dtgProfile.ItemsSource = profileService.GetCandidateProfiles();
                    dtgProfile.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Update fail!");
                }
            }
            else
            {
                MessageBox.Show("Plese int put id or select id");
            }
        }

    }
}
