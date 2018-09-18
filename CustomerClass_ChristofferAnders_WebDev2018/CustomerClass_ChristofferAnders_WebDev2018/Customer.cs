using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClass_ChristofferAnders_WebDev2018
{
    class Customer
    {
        private string Name;
        private int Age;
        private int ZipCode;
        private string Password;

        public Customer(string CostumerName, int CostumerAge, int CostumerZipCode, string CostumerPassword)
        {
            this.Name = CostumerName;
            this.Age = CostumerAge;
            this.ZipCode = CostumerZipCode;
            this.Password = CostumerPassword;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nAge: " + Age + "\nZip: " + ZipCode + "\nPassword: " + Password;
        }
    }
}
