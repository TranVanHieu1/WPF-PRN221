﻿using Candidate_BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface IHRAccountRepository
    {
        public Hraccount GetHRAccountByEmail(string email);

        public List<Hraccount> GetHRAccounts();
    }
}
