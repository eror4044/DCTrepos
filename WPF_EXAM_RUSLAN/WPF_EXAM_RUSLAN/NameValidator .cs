﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_EXAM_RUSLAN
{
    public class NameValidator : ValidationRule
    {
        public override ValidationResult Validate
          (object value, CultureInfo cultureInfo)
        {
            if (value == null)
                return new ValidationResult(false, "value cannot be empty.");
            else
            {
                if (value.ToString().Length > 3)
                    return new ValidationResult
                    (false, "Name cannot be more than 3 characters long.");
            }
            return ValidationResult.ValidResult;
        }
    }
}
