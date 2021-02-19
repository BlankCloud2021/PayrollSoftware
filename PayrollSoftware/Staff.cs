using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSoftware
{
    class Staff
    {
        private float hourlyRate;
        private int hWorked;

        protected float TotalPay { get; set; }
        private float BasicPay { get; set; }

        private string NamOfStaff { get; set; }

        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if(value > 0)
                {
                    hWorked = value;
                }
                hWorked = 0;
            }
        }

        public Staff(string name, float rate)
        {
            NamOfStaff = name;

            hourlyRate = rate;
        }

        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");

            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return $"\n NameOfStaff = {NamOfStaff}\n hourlyRate = {hourlyRate}\n hWorked = {hWorked} \n BasicPay = {BasicPay}\n TotalPay = {TotalPay}";
        }
        
    }
}
