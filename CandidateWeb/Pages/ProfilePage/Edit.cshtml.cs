using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Candidate_BusinessObject;
using Candidate_BusinessObject.Models;
using Candidate_Service;

namespace CandidateWeb.Pages.ProfilePage
{
    public class EditModel : PageModel
    {
        private readonly IProfileService profileService;

        private readonly IJobPostingService jobPostingService;



        public EditModel(IProfileService candidate, IJobPostingService jobPosting)
        {
            profileService = candidate;
            jobPostingService = jobPosting;
        }


        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateprofile =  profileService.GetProfile(id);
            if (candidateprofile == null)
            {
                return NotFound();
            }
            CandidateProfile = candidateprofile;
           ViewData["PostingId"] = new SelectList(jobPostingService.GetJobPostings(), "PostingId", "PostingId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || profileService.GetCandidateProfiles() == null)
            {
                return Page();
            }


            profileService.UpdateProfile(CandidateProfile);
            return RedirectToPage("./Index");
        }

        private bool CandidateProfileExists(string id)
        {
            return profileService.GetProfile(id) != null;
        }
    }
}
