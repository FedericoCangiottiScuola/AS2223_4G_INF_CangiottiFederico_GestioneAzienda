using AziendaDLL;

namespace AS2223_4G_INF_CangiottiFederico_GestioneAzienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Elia", "Rossi", 24, (float)1335.23, new List<string> { "javascript","C#" });
            UIDesigner uidesigner = new UIDesigner("Ugo", "Bianchi", 31, (float)1420.69, new List<string> { "Adobe Photoshop","Adobe Illustrator","Figma" });
            Administration administration = new Administration("Alberto", "Migani", 47, (float)2500.54, 8);
            Department reparto = new Department("Grafica", administration, 3);

            Console.WriteLine(reparto.PrintInformations());    // stampa i dati del reparto

            Console.WriteLine(reparto.ExpandDepartment(5));   // incrementa il numero massimo di dipendenti se la nuova lunghezza è maggiore

            reparto.AddEmployee(developer);
            reparto.AddEmployee(uidesigner);

            Console.WriteLine(reparto.PrintInformations());    // stampa i dati del reparto

            List<Employee> backup = reparto.GetEmployees();    // restituisce la lista dei dipendenti del reparto
            Console.WriteLine(backup[0]);
        }
    }
}
