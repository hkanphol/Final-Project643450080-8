using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final_Project643450080_8
{
    public class searchNote
    {
        public void showHistory()
        {
            string pathNote = Path.Combine(Environment.CurrentDirectory, @"\", "history.csv");
            StreamReader file = null;

            try
            {
                file = new StreamReader(pathNote);
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] data = line.Split(",");
                    Console.WriteLine("Filename:" + data[0]);
                    Console.WriteLine("NOte:" + data[1] + "\n");
                }

                file.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: File not found.");
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
}
