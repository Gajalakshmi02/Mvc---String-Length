using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MVCSLen.Common;
using System.Web.Mvc;

namespace MVCSLen.Models
{
    [MetadataType(typeof(EmployeesMetaData))]
    public partial class Employee
    {
#pragma warning disable CS0618 // Type or member is obsolete
        [System.Web.Mvc.Compare("Email")]
#pragma warning restore CS0618 // Type or member is obsolete
        public string ConfirmEmail { get; set; }
    }
    public class EmployeesMetaData
    {
        [Required]
        public string EName { get; set; }

        [Range(1,100)]
        public int Age { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        [CurrentDate]
        public DateTime HireDate { get; set; }

        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$")]
        public string Email { get; set; }

        
    }
}