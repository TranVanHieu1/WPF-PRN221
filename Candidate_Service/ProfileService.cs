using Candidate_BusinessObject;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class ProfileService : IProfileService

    {
        public ProfileRepo repo;

        public ProfileService()
        {
            repo = new ProfileRepo();
        }

        public bool AddPrifile(CandidateProfile candidate)
        {
            return repo.AddPrifile(candidate);
        }

        public bool DeleteProfile(CandidateProfile candidate)
        {
            return repo.DeleteProfile(candidate);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return repo.GetCandidateProfiles();
        }

        public CandidateProfile GetProfile(string id)
        {
            return repo.GetCandidateProfile(id);
        }

        public bool UpdateProfile(CandidateProfile candidate)
        {
            return repo.UpdateProfile(candidate);
        }
    }
}
