using CleanBlogHigor.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlogHigor.Services
{
   public interface ISmtpService
    {
        bool SendEmail(ContactViewModel model);
    }
}
