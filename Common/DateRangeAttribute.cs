using System;
using System.ComponentModel.DataAnnotations;

namespace MVCSLen.Common
{
    public class DateRangeAttribute : RangeAttribute
    {
        public DateRangeAttribute(string minimumValue) 
            : base(typeof(DateTime), minimumValue, DateTime.Now.ToShortDateString())
        {

        }
    }
}