using Candidate_BusinessObject;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public interface IProfileService
    {
        public CandidateProfile GetProfile(string id);

        public List<CandidateProfile> GetCandidateProfiles();

        public bool UpdateProfile(CandidateProfile candidate);

        public bool AddPrifile(CandidateProfile candidate);

        public bool DeleteProfile(CandidateProfile candidate);
    }

}
