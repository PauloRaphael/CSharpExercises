using ExerciseFiles.Entities;
using System.Globalization;

namespace ExerciseFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Full File Path: ");
            string fullFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(fullFilePath);

                string sourceFolderPath = Path.GetDirectoryName(fullFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\Summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                foreach (string line in lines)
                {
                    using (StreamWriter sw = File.AppendText(targetFilePath))
                    {
                        string[] fields = line.Split(';');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product.Name + ";" + product.Price.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}