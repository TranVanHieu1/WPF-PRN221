using Candidate_BusinessObject;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class ProfileRepo : IProfileRepo
    {
        public bool AddPrifile(CandidateProfile candidate) => CandidateProfileDao.Instance.AddProfile(candidate);

        public bool DeleteProfile(CandidateProfile candidate) => CandidateProfileDao.Instance.DeleteProfile(candidate);

        public CandidateProfile GetCandidateProfile(string id) => CandidateProfileDao.Instance.GetCandidateProfile(id);

        public List<CandidateProfile> GetCandidateProfiles() => CandidateProfileDao.Instance.GetCandidateProfiles();

        public bool UpdateProfile(CandidateProfile candidate) => CandidateProfileDao.Instance.UpdateProfile(candidate);
    }
}
