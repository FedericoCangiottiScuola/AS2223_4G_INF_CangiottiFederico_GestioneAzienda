namespace AziendaDLL
{
    public class Administration : Employee
    {
        int yearsOfExperience;

        public Administration(string firstName, string lastName, int age, float salary, int yearsOfExperience)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
            role = "Administration";

            this.yearsOfExperience = yearsOfExperience;
        }

        /// <summary>
        /// Override del metodo Description() adattato alla classe Administration
        /// </summary>
        /// <returns>Restituisce nome, cognome, età, salario, ruolo e anni di esperienza</returns>
        public override string Description()
        {
            return $"\tFirstname: {firstName}\n\tLastname: {lastName}\n\tAge: {age}\n\tSalary: {salary}\n\tRole: {role}\n\tYears of experience: {yearsOfExperience}";
        }
    }
}
