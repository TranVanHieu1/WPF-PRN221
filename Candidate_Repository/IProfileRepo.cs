using Candidate_BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IProfileRepo
    {
        public CandidateProfile GetCandidateProfile(string id);

        public List<CandidateProfile> GetCandidateProfiles();


        public bool AddPrifile(CandidateProfile candidate);

        public bool UpdateProfile(CandidateProfile candidate);

        public bool DeleteProfile(CandidateProfile candidate);
    }
}
