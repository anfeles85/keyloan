using Org.BouncyCastle.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.Design.AxImporter;

namespace KeyLoan.models
{
    internal class Employee
    {
        private long document;
        private string fullname;
        private string address;
        private string phone;        
        private int type;

        public Employee() { }
        
        public Employee(long document, string fullname, string address, string phone, int type)
        {
            this.Document = document;
            this.Fullname = fullname;
            this.Address = address;
            this.Phone = phone;
            this.Type = type;
        }

        public long Document { get => document; set => document = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Type { get => type; set => type = value; }
    }
}
