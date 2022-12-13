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

        public override string ToString()
        {
            return $"\tFirstname: {firstName}\n\tLastname: {lastName}\n\tAge: {age}\n\tSalary: {salary}\n\tRole: {role}\n\tYears of experience: {yearsExperience}";
        }
    }
}
