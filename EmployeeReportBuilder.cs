using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reporter
{
    public class EmployeeReportBuilder : IEmpoyeeReportBilder
    {
        private EmployeeReport _employeeReport;

        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }

        public void BulidHeader()
        {
            _employeeReport.Header =
                $"Emploees report on date: {DateTime.Now}\n";

            _employeeReport.Header +=
                "\n--------------------------------------------------------------------------------\n";
        }

        public void BulidBody()
        {
            _employeeReport.Body =
                string.Join(Environment.NewLine,
                _employees.Select(e =>
                $"Employee: {e.Name}\t\tSalary: {e.Salary}$"));
        }
        public void BulidFooter()
        {
            _employeeReport.Footer =
                "\n--------------------------------------------------------------------------------\n";

            _employeeReport.Footer +=
                $"\nTotal Employees: {_employees.Count()}," +
                $"Total salary: {_employees.Sum(e => e.Salary)}$ ";
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;

            _employeeReport = new();

            return employeeReport;
        }
    }
}
