using NguyenVanLam_BigShool.Models;
using System;
using System.Collections.Generic;

namespace NguyenVanLam_BigShool.Controllers
{
    public class CourseViewModel
    {
        public List<Category> Categories { get; internal set; }
        public object Category { get; internal set; }
        public string Place { get; internal set; }

        internal DateTime GetDateTime()
        {
            throw new NotImplementedException();
        }
    }
}