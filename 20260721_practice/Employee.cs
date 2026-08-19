using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace _20260721_Practice
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }
        public void ShowProfile()
        {
            Console.WriteLine($"氏名:{Name}");
			Console.WriteLine($"種別:{GetType().Name}");
		}
        public abstract decimal CalculateMonthlyPay();

    }
    
    class FullTimeEmployee : Employee, IOvertimeEligible, IReportable
	{
		private int OvertimeHours = 0;
		public FullTimeEmployee(string name, decimal baseSalary)
            : base(name, baseSalary)
        {
        }
		public void AddOvertimeHours(int hours)
		{
			OvertimeHours += hours;
		}

		public int GetOvertimeHours()
		{
			return OvertimeHours;
		}
		public override decimal CalculateMonthlyPay()
        {
            return BaseSalary;
        }
		public string GenerateReport()
		{
			return $"氏名：{Name} 給与：{CalculateMonthlyPay()}円";
		}
	}
    class PartTimeEmployee : Employee, IReportable
	{
        public decimal HourlyWage { get; set; }
        public int WorkedHours { get; set; }

        public PartTimeEmployee
            (
            string name,
            decimal baseSalary,
            decimal hourWage,
            int workhour)
            : base(name, baseSalary)
        {
            HourlyWage = hourWage;
            WorkedHours = workhour;
        }
        public override decimal CalculateMonthlyPay()
        {
            return HourlyWage * WorkedHours;
        }
		public string GenerateReport()
		{
			return $"氏名：{Name} 給与：{CalculateMonthlyPay()}円";
		}
	}

}
    