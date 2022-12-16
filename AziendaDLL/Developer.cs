namespace AziendaDLL
{
    public class Developer : Employee
    {
        List<string> programmingLanguages;

        public Developer(string firstName, string lastName, int age, float salary, List<string> programmingLanguages)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
            role = "Developer";

            this.programmingLanguages = programmingLanguages;
        }

        /// <summary>
        /// Override del metodo Description() adattato alla classe Developer
        /// </summary>
        /// <returns>Restituisce nome, cognome, età, salario, ruolo e linguaggi di programmazione</returns>
        public override string Description()
        {
            string ris = $"\tFirstname: {firstName}\n\tLastname: {lastName}\n\tAge: {age}\n\tSalary: {salary}\n\tRole: {role}\n\tProgramming languages: ";
            ris += string.Join(", ", programmingLanguages);
            return ris;
        }
    }
}
