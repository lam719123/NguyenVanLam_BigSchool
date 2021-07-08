using NguyenVanLam_BigShool.Models;
using System.Collections.Generic;

namespace NguyenVanLam_BigShool.Controllers
{
    internal class FollowingViewModel
    {
        public List<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}