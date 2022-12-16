namespace AziendaDLL
{
    public class Administration : Employee
    {
        int yearsExperience;

        public Administration(string firstName, string lastName, int age, float salary, int ageExperience)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
            role = "Administration";

            this.yearsExperience = ageExperience;
        }

        /// <summary>
        /// Override del metodo ToString() adattato alla classe Administration
        /// </summary>
        /// <returns>Restituisce nome, cognome, età, salario, ruolo e anni di esperienza</returns>
        public override string ToString()
        {
            return $"\tFirstname: {firstName}\n\tLastname: {lastName}\n\tAge: {age}\n\tSalary: {salary}\n\tRole: {role}\n\tYears of experience: {yearsExperience}";
        }
    }
}
