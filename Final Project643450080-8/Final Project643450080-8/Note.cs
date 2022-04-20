using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Final_Project643450080_8
{
    public class Note
    {
        private string FNcsv;
        private string pathNote;


        public void readNote(string filename)
        {
            FNcsv = filename + ".csv";
            pathNote = Path.Combine(Environment.CurrentDirectory, @"\", FNcsv);

            StreamReader file = null;

            try
            {
                file = new StreamReader(pathNote);
                string line;

                while((line = file.ReadLine()) != null)
                {
                    string[] data = line.Split(",");
                    Console.WriteLine("\nTitle:" + data[0]);
                    Console.WriteLine("Note:" + data[1] + "\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: File not found.");
            }
            finally
            {
                if(file != null)
                {
                    file.Close();
                }
            }
        }

        public void saveNote(string filename, string title, string text)
        {
            DateTime dateTime = DateTime.Now;
            string DT = dateTime.ToString("G");

            FNcsv = filename + ".csv";
            pathNote = Path.Combine (Environment.CurrentDirectory, @"\", FNcsv);
            string fileCsv = title + "," + text + "," + DT;
            File.WriteAllText(pathNote, fileCsv, Encoding.UTF8);

            string FNhistoryFile = "history.csv";
            string pathHIstory = Path.Combine(Environment.CurrentDirectory, @"\", FNhistoryFile);
            string fileHIstory = FNcsv + "," + DT;
            StreamWriter sw = File.AppendText(pathHIstory);
            sw.WriteLine(fileHIstory);
            sw.Close();
        }
        public void deleteNote(string filename)
        {
            string[] removeTheseWords = { filename };
            FNcsv = filename + ".csv";
            string FNhistoryFile = "history.csv";
            pathNote = Path.Combine(Environment.CurrentDirectory, @"\", FNcsv);
            string pathHistorytext = Path.Combine(Environment.CurrentDirectory, @"\", FNhistoryFile);
            var pathAllHistory = pathHistorytext;

            try
            {
                if (File.Exists(pathNote))
                {
                    var lines = File.ReadAllLines(pathAllHistory);
                    lines = lines.Where(line => !line.Contains(filename)).ToArray();
                    File.WriteAllLines(pathAllHistory, lines);
                    File.Delete(pathNote);
                    Console.WriteLine("File deleted.");

                }
            }catch(FileNotFoundException e)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
