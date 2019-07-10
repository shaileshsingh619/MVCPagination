using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebApplication2.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sirname { get; set; }
        public string Age { get; set; }
        public string Designation { get; set; }

        [Display(Name = "Date Of Joining")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOJ { get; set; }
     }

 
}