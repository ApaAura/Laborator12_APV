using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator12_APV.Entities
{
    [Table("EMPLOYEES")]
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }

        public int salary { get; set; }
    }
}
