using Candidate_BusinessObject;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public interface IJobPostingService
    {
        public bool AddJobPosting(JobPosting jobPosting);

        public bool DeleteJobPosting(JobPosting jobPosting);


        public JobPosting GetJobPosting(string jobId);

        public List<JobPosting> GetJobPostings();

        public bool UpdateJobPosting(JobPosting jobPosting);
    }
}
