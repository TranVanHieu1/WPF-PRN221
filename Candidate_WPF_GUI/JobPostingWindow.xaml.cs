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

namespace Candidate_WPF_GUI
{
    /// <summary>
    /// Interaction logic for JobPostingWindow.xaml
    /// </summary>
    public partial class JobPostingWindow : Window
    {
        private IJobPostingService jobPostingService;
        public JobPostingWindow()
        {
            InitializeComponent();
            jobPostingService = new JobPostingService();
        }


        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void jobPostWindow_Loaded(object sender, RoutedEventArgs e)
        {
            dtgJobPost.ItemsSource = jobPostingService.GetJobPostings();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            JobPosting job = new JobPosting();

            job.PostingId = txtPostID.Text;
            job.JobPostingTitle = txtTile.Text;
            job.Description = txtDescription.Text;
            job.PostedDate = DateTime.Parse(dtgPostDate.Text);

            if (jobPostingService.AddJobPosting(job))
            {
                MessageBox.Show("Add Successful!");
                dtgJobPost.ItemsSource = jobPostingService.GetJobPostings();
                dtgJobPost.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Add fail!");
            }
        }

        private void dtgJobPost_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator
                .ContainerFromIndex(dataGrid.SelectedIndex);

            DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;

            string id = ((TextBlock)RowColumn.Content).Text;
            JobPosting jobPosting = jobPostingService.GetJobPosting(id);

            txtPostID.Text = jobPosting.PostingId.ToString();
            txtTile.Text = jobPosting.JobPostingTitle.ToString();
            dtgPostDate.Text = jobPosting.PostedDate.ToString();
            txtDescription.Text = jobPosting.Description.ToString();

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            JobPosting jobPosting = jobPostingService.GetJobPosting(txtPostID.Text);

            if (jobPosting != null)
            {
                jobPosting.JobPostingTitle = txtTile.Text;
                jobPosting.Description = txtDescription.Text;
                jobPosting.PostedDate = DateTime.Parse(dtgPostDate.Text);
                if (jobPostingService.UpdateJobPosting(jobPosting))
                {
                    MessageBox.Show("Update Successful!");
                    dtgJobPost.ItemsSource = jobPostingService.GetJobPostings();
                    dtgJobPost.Items.Refresh();
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
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPostID.Text))
                {
                    MessageBox.Show("Please enter a valid ID.");
                    return;
                }

                JobPosting jobPosting = jobPostingService.GetJobPosting(txtPostID.Text);

                if (jobPosting != null)
                {
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this job posting?", "Confirmation",
                                                              MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (result == MessageBoxResult.Yes)
                    {
                        if (jobPostingService.DeleteJobPosting(jobPosting))
                        {
                            MessageBox.Show("Delete Successful!");
                            dtgJobPost.ItemsSource = jobPostingService.GetJobPostings();
                            
                        }
                        else
                        {
                            MessageBox.Show("Delete failed.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID or select a job posting.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
