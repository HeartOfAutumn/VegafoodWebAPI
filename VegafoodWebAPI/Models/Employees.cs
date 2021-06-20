using System;
using System.Collections.Generic;

namespace VegafoodWebAPI.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Orders = new HashSet<Orders>();
        }

        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
