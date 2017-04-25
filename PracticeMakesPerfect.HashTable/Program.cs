using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialization
            Person[] people = new Person[]
            {                
                new Person("George", "Washington"),
                new Person("Thomas", "Jefferson"),
                new Person("Abraham", "Lincoln"),
                new Person("James", "Madison"),
                new Person("Andrew", "Jackson"),
                new Person("Alexander", "Hamilton"),
                new Person("Barack", "Obama"),
                new Person("George", "Bush"),
                new Person("Donald", "Trump")
            };

            HashTable table = new HashTable();

            // Insertion
            System.Console.WriteLine("Do Hashtable Insertions");
            System.Console.WriteLine("-----------------------");

            foreach (Person p in people)
            {
                table.Add(p.Key, p);
            }

            System.Console.WriteLine("Wrote nodes to HashTable");

            System.Console.Write(System.Environment.NewLine);

            // Lookup
            System.Console.WriteLine("Perform Lookup");
            System.Console.WriteLine("--------------");

            HashNode lookup1 = table.Get(new Person("Barack", "Obama").Key);
            if (lookup1 != null)
            {
                Person result = (Person)lookup1.value;
                System.Console.WriteLine("Found matching node! " + result.FirstName + " " + result.LastName);
            }
            else
            {
                System.Console.WriteLine("Did not find a matching node.");
            }

            HashNode lookup2 = table.Get(new Person("George", "Trump").Key);
            if (lookup2 != null)
            {
                Person result = (Person)lookup2.value;
                System.Console.WriteLine("Found matching node! " + result.FirstName + " " + result.LastName);
            }
            else
            {
                System.Console.WriteLine("Did not find a matching node.");
            }

            System.Console.Write(System.Environment.NewLine);

            // Iteration
            System.Console.WriteLine("Print Table");
            System.Console.WriteLine("-----------");

            HashNode[] nodes = table.GetTable();
            for (int i = 0; i < nodes.Count(); i++)
            {
                if(nodes[i] != null)
                {
                    HashNode node = nodes[i];
                    while (node != null)
                    {
                        string message = "Index: " + i.ToString() + " Key: " + node.key;
                        System.Console.WriteLine(message);
                        node = node.next;
                    }
                }
                else
                {
                    string message = "Index: " + i.ToString() + " No Entry";
                    System.Console.WriteLine(message);
                }
            }

            System.Console.ReadLine();
        }
    }
}
