using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSoftware
{
    class Manager : Staff
    {
        private const float managerHourlyRate = 50;
        
        public int Allowance { get; private set; }
        public Manager(string name) : base(name, managerHourlyRate) { }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;
        }
    }
}
