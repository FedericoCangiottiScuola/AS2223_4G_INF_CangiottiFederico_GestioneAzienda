using AziendaDLL;

namespace AS2223_4G_INF_CangiottiFederico_GestioneAzienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Elia", "Rossi", 24, (float)1335.23, new List<string> { "javascript","C#" });
            UIDesigner uidesigner = new UIDesigner("Ugo", "Bianchi", 31, (float)1420.69, new List<string> { "Adobe Photoshop","Adobe Illustrator","Figma" });
            Administrator admin = new Administrator("Alberto", "Migani", 47, (float)2500.54, 8);
            Department dipartimento = new Department("Prova", admin, 3);

            Console.WriteLine(dipartimento.PrintInformations());    // stampa i dati del reparto

            dipartimento.ExpandDepartment(5);   // incrementa il numero massimo di dipendenti

            Console.WriteLine(dipartimento.PrintInformations());    // stampa i dati del reparto

            List<Employee> backup = dipartimento.GetEmployees();    // restituisce la lista dei dipendenti del reparto
        }
    }
}
