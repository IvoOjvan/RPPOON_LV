using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    class RegistrationValidator : IRegistrationValidator
    {
        private IPasswordValidationService passwordValidationService;
        private IEmailValidatorService emailValidatorService;

        public RegistrationValidator(int minPasswordLength)
        {
            passwordValidationService = new PasswordValidator(minPasswordLength);
            emailValidatorService = new EmailValidator();
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            return
                passwordValidationService.IsValidPassword(entry.Password) &&
                emailValidatorService.IsValidAddress(entry.Email);
        }
    }
}
