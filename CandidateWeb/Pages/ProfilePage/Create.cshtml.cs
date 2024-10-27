using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Candidate_BusinessObject;
using Candidate_BusinessObject.Models;
using Candidate_Service;

namespace CandidateWeb.Pages.ProfilePage
{
    public class CreateModel : PageModel
    {
        private readonly IProfileService profileService;

        private readonly IJobPostingService jobPostingService;



        public CreateModel(IProfileService candidate, IJobPostingService jobPosting)
        {
            profileService = candidate;
            jobPostingService = jobPosting;
        }

        public IActionResult OnGet()
        {
        ViewData["PostingId"] = new SelectList(jobPostingService.GetJobPostings(), "PostingId", "PostingId");
            return Page();
        }

        [BindProperty]
        public CandidateProfile CandidateProfile { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || profileService.GetCandidateProfiles() == null || CandidateProfile == null)
            {
                return Page();
            }

            profileService.AddPrifile(CandidateProfile);

            return RedirectToPage("./Index");
        }
    }
}
