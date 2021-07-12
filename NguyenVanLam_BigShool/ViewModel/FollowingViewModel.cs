using NguyenVanLam_BigShool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenVanLam_BigShool.ViewModel
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}
