﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testWebApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Salary { get; set; }

        public string Company { get; set; }

        public string Dept { get; set; }
    }
}