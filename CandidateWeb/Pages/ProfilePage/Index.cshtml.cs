using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObject;
using Candidate_BusinessObject.Models;
using Candidate_Service;

namespace CandidateWeb.Pages.ProfilePage
{
    public class IndexModel : PageModel
    {

        private readonly IProfileService profileService;

        public IndexModel(IProfileService candidate)
        {
            profileService = candidate;
        }

        public IList<CandidateProfile> CandidateProfile { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if(profileService.GetCandidateProfiles() != null)
            {
                CandidateProfile = profileService.GetCandidateProfiles();
            }
        }
    }
}
