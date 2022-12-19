namespace AziendaDLL
{
    public class Department
    {
        string name;
        Employee headDepartment;
        int nMaxEmployees;
        List<Employee> employees;

        public Department(string name, Employee headDepartment, int nMaxEmployees)
        {
            this.name = name;
            this.headDepartment = headDepartment;
            this.nMaxEmployees = nMaxEmployees;
            employees = new List<Employee>
            {
                headDepartment
            };
        }

        /// <summary>
        /// Aggiunge un dipendente alla lista della classe Department
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Restituisce l'esito della operazione: true(riuscita), false(non riuscita)</returns>
        public bool AddEmployee(Employee employee)
        {
            if (employees.Count+1 <= nMaxEmployees)
            {
                employees.Add(employee);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Recupera tutte le informazioni utili e le concatena in una stringa formattata
        /// </summary>
        /// <returns>Stringa con informazioni formattate</returns>
        public string GetInformations()
        {
            string ris = "";
            int i = 1;

            ris += $"\nDepartment name: {name}\nMax employees: {nMaxEmployees}\nEmployees: {employees.Count}\n";
            foreach(Employee emp in employees)
            {
                ris += $"{i}) {emp.Description()}\n\n";
                i++;
            }
            return ris;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Lista dipendenti</returns>
        public List<Employee> GetEmployees()
        {
            return employees;
        }

        /// <summary>
        /// Incrementa il limite dei dipendenti in un reparto se la nuova lunghezza è maggiore della precedente
        /// </summary>
        /// <param name="newLength"></param>
        /// <returns>Restituisce l'esito della operazione: true(riuscita), false(non riuscita)</returns>
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
