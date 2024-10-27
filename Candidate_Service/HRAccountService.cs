using Candidate_BusinessObject;
using Candidate_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepository iAccountRepo;
        public HRAccountService(IHRAccountRepository hRAccountRepository)
        {
            iAccountRepo = hRAccountRepository;
        }

        public HRAccountService()
        {
            iAccountRepo = new HRAcountRepository();
        }
        public Hraccount GetHraccountByEmail(string email)
        {
            return iAccountRepo.GetHRAccountByEmail(email);
        }

        public List<Hraccount> GetHraccounts()
        {
            return iAccountRepo.GetHRAccounts();
        }
    }
}
