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
    public class DeleteModel : PageModel
    {
        private readonly IProfileService profileService;



        public DeleteModel(IProfileService candidate)
        {
            profileService = candidate;
        }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateprofile = profileService.GetProfile(id);

            if (candidateprofile == null)
            {
                return NotFound();
            }
            else
            {
                CandidateProfile = candidateprofile;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || profileService.GetCandidateProfiles() == null)
            {
                return NotFound();
            }

            var candidateprofile = profileService.GetProfile(id);
            if (candidateprofile != null)
            {
                profileService.DeleteProfile(candidateprofile);
            }

            return RedirectToPage("./Index");
        }
    }
}
