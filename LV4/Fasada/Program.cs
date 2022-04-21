using System;

namespace Fasada
{
    class Program
    {
        static void Main(string[] args)
        {
            const string password = "ZN1dVLrj";
            const string mail = "test@mail.hr";
            const int minPasswordLength = 8;

            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator(minPasswordLength);

            Console.WriteLine(emailValidator.IsValidAddress(mail));
            Console.WriteLine(passwordValidator.IsValidPassword(password));

            UserEntry user = UserEntry.ReadUserFromConsole();
            RegistrationValidator registrationValidation = new RegistrationValidator(minPasswordLength);

            Console.WriteLine(registrationValidation.IsUserEntryValid(user));

        }
    }
}
