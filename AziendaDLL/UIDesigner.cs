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
            role = "UI designer";

            this.designPrograms = designPrograms;
        }

        /// <summary>
        /// Override del metodo ToString() adattato alla classe UIDesigner
        /// </summary>
        /// <returns>Restituisce nome, cognome, età, salario, ruolo e programmi di grafica</returns>
        public override string ToString()
        {
            string ris = $"\tFirstname: {firstName}\n\tLastname: {lastName}\n\tAge: {age}\n\tSalary: {salary}\n\tRole: {role}\n\tDesign programs: ";
            ris += string.Join(", ", designPrograms);
            return ris;
        }
    }
}
