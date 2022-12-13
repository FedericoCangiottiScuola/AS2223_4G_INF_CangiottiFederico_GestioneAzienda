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
            if (nEmployees < nMaxEmployees)
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

        public string GetEmployees()
        {
            string ris = "";
            int i = 1;
            foreach(Employee emp in employees)
            {
                ris += $"{i}) {emp}";
                i++;
            }
            return ris;
        }

        public void ExpandDepartment(int newLength)
        {
            nMaxEmployees = newLength;
        }
    }
}
