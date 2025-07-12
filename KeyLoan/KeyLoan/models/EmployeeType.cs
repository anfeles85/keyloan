using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLoan.models
{
    internal class EmployeeType
    {
        private int id;
        private string description;

        public EmployeeType(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
    }
}
