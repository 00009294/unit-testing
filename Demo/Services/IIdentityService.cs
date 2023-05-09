using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public interface IIdentityService
    {
        public bool IsPasswordStrong(string password);
    }
}
