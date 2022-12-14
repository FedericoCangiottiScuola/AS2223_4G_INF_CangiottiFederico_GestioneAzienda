namespace AziendaDLL
{
    public class Department
    {
        string name;
        Employee departmentHead;
        int nMaxEmployees;
        int nEmployees;
        List<Employee> employees;

        public Department(string name, Employee departmentHead, int nMaxEmployees)
        {
            this.name = name;
            this.departmentHead = departmentHead;
            this.nMaxEmployees = nMaxEmployees;
            nEmployees = 0;
            employees = new List<Employee>
            {
                departmentHead
            };
            nEmployees++;
        }

        public bool AddEmployee(Employee employee)
        {
            if (nEmployees+1 <= nMaxEmployees)
            {
                employees.Add(employee);
                nEmployees++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PrintInformations()
        {
            string ris = "";
            int i = 1;

            ris += $"\nDepartment name: {name}\nMax employees: {nMaxEmployees}\nEmployees: {nEmployees}\n";
            foreach(Employee emp in employees)
            {
                ris += $"{i}) {emp.ToString()}\n\n";
                i++;
            }
            return ris;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public bool ExpandDepartment(int newLength)
        {
            if (newLength > nMaxEmployees)
            {
                nMaxEmployees = newLength;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
