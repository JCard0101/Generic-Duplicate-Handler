using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Input1: Removing duplicate string output will result in Hello World.

            var handlerString = new DuplicateHandler<string>();

            var inputString = new List<string> { "Hello", "World", "Hello", "Hello" };

            var outputString = handlerString.RemoveDuplicates(inputString);

            Console.WriteLine("Input 1 Output:\n");

            foreach (var resultString in outputString)
            {
                Console.WriteLine(resultString);
            }

            //Input2: Removing duplicate int values output will result in 1 2 3 4 5.

            var handlerInt = new DuplicateHandler<int>();

            var listInt = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 3 };

            var output2 = handlerInt.RemoveDuplicates(listInt);

            Console.WriteLine("\nInput 2 Output:\n");

            foreach (var resultInt in output2)
            {
                Console.WriteLine(resultInt);
            }

            //Input3: Removing duplicate items in list output will result in newPage file name.

            var handlerFile = new DuplicateHandler<Page>();

            var listOject = new List<Page>();

            var newPage = new Page { Id = 1, FileName = "TestFile.txt", DocumentType = "TestDocType", ImportDate = DateTime.Now, PageNumber = 1 };

            listOject.Add(newPage);
            listOject.Add(newPage);
            listOject.Add(newPage);

            var output3 = handlerFile.RemoveDuplicates(listOject);

            Console.WriteLine("\nInput 3 Output:\n");

            foreach (var resultObject in output3)
            {
                Console.WriteLine(resultObject.FileName);
            }
        }

        public class DuplicateHandler<T>
        {
            public ICollection<T> RemoveDuplicates(ICollection<T> itemListCollection)
            {
                return itemListCollection.Distinct().ToList();
            }
        }

    }
}

