using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fasada
{
    class EmailValidator : IEmailValidatorService
    {

        public bool IsValidAddress(string candidate)
        {
            if (String.IsNullOrEmpty(candidate)) 
            {
                return false;
            }
            return ContainsSingleAtSign(candidate) && ContainsValidDomain(candidate);
        }

        private bool ContainsSingleAtSign(string candidate) 
        {
            return candidate.Count(it => (it == '@')) == 1;
        }

        private bool ContainsValidDomain(string candidate) 
        {
            return candidate.EndsWith(".com") || candidate.EndsWith(".hr");
        }
    }
}
