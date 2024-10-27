using Candidate_BusinessObject;
using Candidate_BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class JobPostDAO
    {
        private  CandidateManagementContext dbContext;

        private static JobPostDAO instance;

        public static JobPostDAO Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new JobPostDAO();
                }
                return instance;
            }
        }

        public JobPostDAO()
        {
            dbContext = new CandidateManagementContext();
        }

        public  JobPosting GetJobPosting(string jobId)
        {
            return dbContext.JobPostings.SingleOrDefault(m => m.PostingId.Equals(jobId));
        }



        public  bool AddJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPost = GetJobPosting(jobPosting.PostingId);
            try
            {
                if(jobPost == null)
                {
                    dbContext.JobPostings.Add(jobPosting);
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not save");
            }
            return isSuccess;
        }

        public  bool DeleteJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPost = GetJobPosting(jobPosting.PostingId);
            try
            {
                if (jobPost != null)
                {
                    dbContext.JobPostings.Remove(jobPosting);
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not save");
            }
            return isSuccess;
        }

        public  bool UpdateJobPosting(JobPosting jobPosting)
        {
            bool isSuccess = false;
            JobPosting jobPost = GetJobPosting(jobPosting.PostingId);

            try
            {
                if (jobPost != null)
                {
                    dbContext.Entry<JobPosting>(jobPosting).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
            }catch (Exception ex)
            {

            }
            return isSuccess;
        }

        public List<JobPosting> GetJobPostings()
        {
            return dbContext.JobPostings.ToList();
        }


    }
}
