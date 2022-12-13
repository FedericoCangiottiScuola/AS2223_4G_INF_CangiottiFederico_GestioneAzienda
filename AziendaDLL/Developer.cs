namespace AziendaDLL
{
    public class Developer : Employee
    {
        List<string> programmingLanguages;

        public Developer(List<string> programmingLanguages)
        {
            this.programmingLanguages = programmingLanguages;
        }
    }
}
