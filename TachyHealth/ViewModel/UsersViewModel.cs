using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TachyHealth.Models;

namespace TachyHealth.ViewModel
{
    public class UsersViewModel
    {
        public IList<ApplicationUser> Users;
        public UsersViewModel()
        {
            Users = new List<ApplicationUser>();
        }

    }
}