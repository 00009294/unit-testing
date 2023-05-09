using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class IdentityService : IIdentityService
    {
        public bool IsPasswordStrong(string password)
        {
            // lenght > 8
            // must include special chars
            // uppercase
            // lowercase
            // didgits
            bool length = false;
            bool chars = false;
            bool uppercase = false;
            bool lowercase = false;
            bool digits = false;
            if(password.Length > 8) length= true;
            foreach(var item in password)
            {
                if(item > 32 && item < 48) chars= true;
                if(item > 64 && item < 91) uppercase = true;
                if(item > 96 && item < 123) lowercase = true;
                if(item > 47 && item < 58) digits = true;
            }
            return length & chars & uppercase & lowercase & digits;

        }
    }
}
