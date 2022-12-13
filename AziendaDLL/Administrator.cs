namespace AziendaDLL
{
    public class Administrator : Employee
    {
        int ageExperience;

        public Administrator(string firstName, string lastName, int age, float salary, int ageExperience)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;

            this.ageExperience = ageExperience;
        }
    }
}
