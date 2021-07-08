﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace NguyenVanLam_BigShool.ViewModel
{
    internal class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/MM/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.AssumeLocal,
                out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }
}