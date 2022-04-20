using System;
using System.Drawing;
using Console = Colorful.Console;

namespace Final_Project643450080_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            bool choiceB;
            Note note = new Note();

            do
            {
                Console.WriteAscii("Sticky Note", ColorTranslator.FromHtml("#B9DCF0"));
                Console.WriteLine("\tChoose your choice:\n", ColorTranslator.FromHtml("#7EBDA7"));
                Console.WriteLine("\t[1] Add Note", ColorTranslator.FromHtml("#B9DCF0"));
                Console.WriteLine("\t[2] Show all Note", ColorTranslator.FromHtml("#F2AE7E"));
                Console.WriteLine("\t[3] Exit Program\n", ColorTranslator.FromHtml("#BD8F7E"));
                Console.Write("Your choice >> ", ColorTranslator.FromHtml("#B9F0BD"));
                choiceB = int.TryParse(Console.ReadLine(), out choice);
                Console.Clear();

                if (choiceB)
                {
                    if (choice == 1)
                    {
                        string saveChoice;
                        int choiceCheck = 0;

                        Console.Write("\n\tInsert Name of filename >> ", ColorTranslator.FromHtml("#EDB4B6"));
                        string filename = Console.ReadLine();
                        Console.Write("\n\tInsert Name of Title >> ", ColorTranslator.FromHtml("#F07ECB"));
                        string title = Console.ReadLine();
                        Console.Write("\n\tEnter note:", ColorTranslator.FromHtml("#D66FB6"));
                        string text = Console.ReadLine();
                        Console.WriteLine("Filename = " + filename, ColorTranslator.FromHtml("#EDEAC5"));
                        Console.WriteLine("Title = " + title, ColorTranslator.FromHtml("#EDADBE"));
                        Console.WriteLine("Note = " + text, ColorTranslator.FromHtml("#95D8ED"));

                        do
                        {
                            Console.Write("\n\tSave?(Y/N) >> ", ColorTranslator.FromHtml("#86F582"));
                            saveChoice = Console.ReadLine();

                            if (saveChoice == "y" || saveChoice == "Y")
                            {
                                note.saveNote(filename, title, text);
                                Console.WriteLine("Save Successful!!", ColorTranslator.FromHtml("#F5E941"));
                                Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#DBD13B"));
                                Console.ReadLine();
                                Console.Clear();
                                choiceCheck = 0;

                            }
                            else if (saveChoice == "n" || saveChoice == "N")
                            {
                                Console.WriteLine("Note is Unsave!!", ColorTranslator.FromHtml("#F5E941"));
                                Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#DBD13B"));
                                Console.ReadLine();
                                Console.Clear();
                                choiceCheck = 0;
                            }
                            else
                            {
                                Console.WriteLine("Error input!!", ColorTranslator.FromHtml("#63B560"));
                                choiceCheck = 1;
                            }
                        } while (choiceCheck != 0);
                    }
                    else if (choice == 2)
                    {
                        string filename;
                        int choiceSearch = 0;
                        bool choiceS;

                        do
                        {
                            searchNote sN = new searchNote();
                            sN.showHistory();
                            Console.WriteLine("\tChoose your choice:\n", ColorTranslator.FromHtml("#AF7FB8"));
                            Console.WriteLine("\t[1] Read Note", ColorTranslator.FromHtml("#F27E99"));
                            Console.WriteLine("\t[2] Delete Note", ColorTranslator.FromHtml("#F25E6D"));
                            Console.WriteLine("\t[3] Return to main menu\n", ColorTranslator.FromHtml("#D95562"));
                            Console.Write("Your choice >> ", ColorTranslator.FromHtml("#D197DB"));
                            choiceS = int.TryParse(Console.ReadLine(), out choiceSearch);

                            if (choiceS)
                            {
                                if (choiceSearch == 1)
                                {
                                    Console.Write("Input your filename >> ", ColorTranslator.FromHtml("#B83728"));
                                    filename = Console.ReadLine();
                                    note.readNote(filename);
                                    Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#F54936"));
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else if (choiceSearch == 2)
                                {
                                    Console.Write("Input your filename >> ", ColorTranslator.FromHtml("#B83728"));
                                    filename = Console.ReadLine();
                                    note.deleteNote(filename);
                                    Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#F54936"));
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else if (choiceSearch == 3)
                                {
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("Choice is error", ColorTranslator.FromHtml("#B8915F"));
                                    Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#F5C380"));
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            else if (!choiceS)
                            {
                                Console.WriteLine("Choice is error", ColorTranslator.FromHtml("#B8915F"));
                                Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#F5C380"));
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Choice is error", ColorTranslator.FromHtml("#B8915F"));
                                Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#F5C380"));
                                Console.ReadLine();
                                Console.Clear();
                            }
                        } while (choiceSearch != 3);
                    }
                    else if (choice == 3)
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Choice is error", ColorTranslator.FromHtml("#B8915F"));
                        Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#F5C380"));
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (!choiceB)
                {
                    Console.WriteLine("Choice is error", ColorTranslator.FromHtml("#B8915F"));
                    Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#F5C380"));
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Choice is error", ColorTranslator.FromHtml("#B8915F"));
                    Console.WriteLine("Press Enter to return", ColorTranslator.FromHtml("#F5C380"));
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choice != 3);
        }
    }
}
