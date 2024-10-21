using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Subscriber
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CallMinutesPerMonth { get; set; }
        public int SMSPerMonth { get; set; }
        public double MonthlyFee { get; set; }
        public bool HasRoaming { get; set; }
        public bool HasDataPlan { get; set; }


        public double CalculateDiscountedFee()
        {
            double discountPercentage = 20;
            return MonthlyFee - (MonthlyFee * discountPercentage / 100);
        }


        public double CalculateRegularCustomerDiscount()
        {
            double additionalDiscount = 5;
            return CalculateDiscountedFee() - (CalculateDiscountedFee() * additionalDiscount / 100);
        }


        public double DiscountedFee
        {
            get
            {
                return CalculateDiscountedFee();
            }
        }


        public double RegularCustomerDiscountedFee
        {
            get
            {
                return CalculateRegularCustomerDiscount();
            }
        }


        public Subscriber()
        {
        }


        public Subscriber(string name, string phoneNumber, string address, int callMinutesPerMonth, int smsPerMonth, double monthlyFee, bool hasRoaming, bool hasDataPlan, int v, int v1)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            CallMinutesPerMonth = callMinutesPerMonth;
            SMSPerMonth = smsPerMonth;
            MonthlyFee = monthlyFee;
            HasRoaming = hasRoaming;
            HasDataPlan = hasDataPlan;
        }
    }
}