namespace Delegate_Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[]
            {
                new Employee(1, "Ali",'M',7000m),
                new Employee(2, "Ahmed",'M', 6000m),
                new Employee(3, "Ahmed",'M', 6000m),
                new Employee(4, "Ahmed",'M', 6000m),
                new Employee(5, "Ahmed",'M', 6000m),
                new Employee(6, "Ahmed",'M', 6000m),
                new Employee(7, "Ahmed",'M', 6000m),





            };





            Reports reports = new Reports();
            reports.ProcessEmployee(emps, "total sales morethan 60 k", (emp) => emp.TotalSales >= 60000m);
            reports.ProcessEmployee(emps, "total sales between 30 to 60 k", (emp) => emp.TotalSales >= 30000m && emp.TotalSales <= 60000m);
            reports.ProcessEmployee(emps, "total sales lessthan 30k", (emp) => emp.TotalSales < 30000m);

            bool greater60(Employee emp) => emp.TotalSales >= 60000m;
            bool inbetween3060(Employee emp) => emp.TotalSales >= 30000m && emp.TotalSales <= 60000m;
            bool lessthan30(Employee emp) => emp.TotalSales < 30000m;

            //reports.TotalSalesmorethan60k(emps);
            //reports.TotalSalesbetween30kto59999k(emps);
            //reports.TotalSaleslessthan30k(emps);
        }
    }
}