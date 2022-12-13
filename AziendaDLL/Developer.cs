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

        public override string ToString()
        {
            string ris = $"\tFirstname: {firstName}\n\tLastname: {lastName}\n\tAge: {age}\n\tSalary: {salary}\n\tRole: {role}\n\tProgramming languages: ";
            ris += string.Join(", ", programmingLanguages);
            return ris;
        }
    }
}
