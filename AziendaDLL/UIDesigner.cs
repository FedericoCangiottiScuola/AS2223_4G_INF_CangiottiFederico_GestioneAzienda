namespace AziendaDLL
{
    public class UIDesigner : Employee
    {
        List<string> designPrograms;

        public UIDesigner(string firstName, string lastName, int age, float salary, List<string> designPrograms)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;

            this.designPrograms = designPrograms;
        }
    }
}
