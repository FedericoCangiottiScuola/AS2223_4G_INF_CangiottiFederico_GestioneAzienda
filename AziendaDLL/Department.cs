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

        /// <summary>
        /// Aggiunge un dipendente alla lista della classe Department
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Restituisce l'esito della operazione: true(riuscita), false(non riuscita)</returns>
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

        /// <summary>
        /// Recupera tutte le informazioni utili e le concatena in una stringa formattata
        /// </summary>
        /// <returns>Stringa con informazioni formattate</returns>
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
