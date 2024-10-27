using Candidate_BusinessObject;
using Candidate_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace CandidateWeb.Pages
{
    public class LoginModel : PageModel
    {
        private IHRAccountService hraccountService;

        public LoginModel(IHRAccountService hRAccountService) 
        {
            this.hraccountService = hRAccountService;
        }
        public void OnPost()
        {
            String email = Request.Form["txtEmail"];

            String password = Request.Form["txtPassword"];

            Hraccount hraccount = hraccountService.GetHraccountByEmail(email);
            if(hraccount != null && hraccount.Password.Equals(password))
            {
                HttpContext.Session.SetString("RoleID", hraccount.MemberRole.ToString());
                Response.Redirect("/ProfilePage");
            }
            else
            {
                Response.Redirect("/Error");
            }

            
        }
    }
}
