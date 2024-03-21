using System;
using System.ComponentModel.DataAnnotations;

namespace MVCSLen.Common
{
    public class CurrentDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime = Convert.ToDateTime(value);

            return dateTime <= DateTime.Now;
        }
    }
}