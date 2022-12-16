namespace AziendaDLL
{
    public class Employee
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected float salary;
        protected string role;

        /// <summary>
        /// Metodo virtuale che restituisce le informazioni del dipendente
        /// </summary>
        /// <returns></returns>
        public virtual string Description()
        {
            return "";
        }
    }
}
