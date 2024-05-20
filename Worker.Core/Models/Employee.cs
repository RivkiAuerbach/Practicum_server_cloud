﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Core.Models
{
    public enum Gender { male , female }
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateSartingWork { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public List<Role> Roles { get; set; }
        public Employee()
        {
            IsActive = true;
        }

    }
}
