using Candidate_BusinessObject;
using Candidate_BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class CandidateProfileDao
    {
        private static CandidateProfileDao instance;

        public CandidateManagementContext dbContext;

        public CandidateProfileDao()
        {
            dbContext = new CandidateManagementContext();
        }

        public static CandidateProfileDao Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDao();
                }
                return instance;
            }
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return dbContext.CandidateProfiles.ToList();
        }

        public CandidateProfile GetCandidateProfile(string id) 
        {
            return dbContext.CandidateProfiles.SingleOrDefault(x => x.CandidateId.Equals(id));
        }

        public bool AddProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidate = GetCandidateProfile(candidateProfile.CandidateId) ;
            try
            {
                if (candidate == null)
                {
                    dbContext.CandidateProfiles.Add(candidateProfile);
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

        public bool DeleteProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidate = GetCandidateProfile(candidateProfile.CandidateId);
            try
            {
                if (candidate != null)
                {
                    dbContext.CandidateProfiles.Remove(candidate);
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Can not delete");
            }
            return isSuccess;
        }

        public bool UpdateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidate = GetCandidateProfile(candidateProfile.CandidateId);

            try
            {
                if (candidate != null)
                {
                    dbContext.Entry<CandidateProfile>(candidate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dbContext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

            }
            return isSuccess;
        }
    }
}
