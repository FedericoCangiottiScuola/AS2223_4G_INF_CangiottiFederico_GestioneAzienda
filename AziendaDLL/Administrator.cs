namespace AziendaDLL
{
    public class Administrator : Employee
    {
        int yearsExperience;

        public Administrator(string firstName, string lastName, int age, float salary, int ageExperience)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
            role = "Administrator";

            this.yearsExperience = ageExperience;
        }

        /// <summary>
        /// Override del metodo ToString() adattato alla classe Administrator
        /// </summary>
        /// <returns>Restituisce nome, cognome, età, salario, ruolo e anni di esperienza</returns>
        public override string ToString()
        {
            return $"\tFirstname: {firstName}\n\tLastname: {lastName}\n\tAge: {age}\n\tSalary: {salary}\n\tRole: {role}\n\tYears of experience: {yearsExperience}";
        }
    }
}
