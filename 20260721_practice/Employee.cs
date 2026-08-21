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
		public ITaxStrategy TaxStrategy { get; set; }
		public Employee(string name, decimal baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
			TaxStrategy = new FlatTaxStrategy();
		}
        public void ShowProfile()
        {
            Console.WriteLine($"氏名:{Name}");
            Console.WriteLine($"種別:{GetType().Name}");
        }
        public abstract decimal CalculateMonthlyPay();

        public void MonthlyRoutine()
        {
            ShowProfile();
            BeforeCalcHook();
            CalculateMonthlyPay();
            AfterCalcHook();
        }
        protected virtual void BeforeCalcHook()
        {
        }
        protected virtual void AfterCalcHook()
		{
		}


	}
    
    class FullTimeEmployee : Employee, IOvertimeEligible, IReportable, IPayable
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
        protected override void BeforeCalcHook()
        {
            Console.WriteLine("残業時間を締める処理");
        }
        public void Pay()
        {
            Console.WriteLine($"{Name}さんに{CalculateMonthlyPay()}円を振込");
        }
      
	}
    class PartTimeEmployee : Employee, IReportable, IPayable
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
        //public override decimal CalculateMonthlyPay()
        //{
        //    decimal gross = HourlyWage * WorkedHours;
        //    decimal tax = TaxStrategy.CalcTax(gross);

        //    return gross - tax;
        //}
        public string GenerateReport()
		{
			return $"氏名：{Name} 給与：{CalculateMonthlyPay()}円";
		}
        public void Pay()
		{
			Console.WriteLine($"{Name}さんに{CalculateMonthlyPay()}円を振込");
		}

	}
        class FlatTaxStrategy : ITaxStrategy
        {
            public decimal CalcTax(decimal gross)
            {
                return gross * 0.10m;
            }
        }
    class ProgressiveTaxStrategy : ITaxStrategy
    {
        public decimal CalcTax(decimal gross)
        {
            if (gross <= 200000)
            {
                return gross * 0.05m;
            }
            else
            {
                return 200000 * 0.05m + (gross - 200000) * 0.10m;
            }
        }
    }
}
    