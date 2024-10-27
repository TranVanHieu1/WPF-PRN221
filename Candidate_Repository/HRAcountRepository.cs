using Candidate_BusinessObject;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class HRAcountRepository : IHRAccountRepository
    {

       

        
        public Hraccount GetHRAccountByEmail(string email) => HRAccountDAO.Instance.GetHraccountByEmail(email);


        public List<Hraccount> GetHRAccounts()=> HRAccountDAO.Instance.GetHraccounts();
       
    }

    
}
