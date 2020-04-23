using System;

namespace SplitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfNames = 5;
            string namesLine = "";
            namesLine = GetNames(numOfNames);
            Console.WriteLine($"All Names in a single string: {namesLine}");
            ShowNames(namesLine);
        }

        static public string GetNames(int numOfNames)
        {
            string names = "";
            for (int i = 0; i < numOfNames; i++)
            {
                names += PromptUser("Please enter a name.") + " ";
            }
            return names;
        }
        static public void ShowNames(string names)
        {
            string[] nameList = names.Split(" ");
            for (int i = 0; i < nameList.Length - 1; i++)
            {
                Console.WriteLine($"Array Item {i}: " + nameList[i]);
            }
        }

        static public string PromptUser(string prompt)
        {
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            return response;
        }
    }
}
