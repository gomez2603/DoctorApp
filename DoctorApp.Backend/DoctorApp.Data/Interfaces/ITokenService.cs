using DoctorApp.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApp.Data.Interfaces
{
    public interface ITokenService
    {
        string GetToken(Users user);
    }
}
