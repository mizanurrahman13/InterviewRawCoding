using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExample
{
    public class HashSetOperation
    {
        public void HashSetOperations()
        {
            var hashSetNumber = new HashSet<int>();

            var hashSetFriendsName = new HashSet<string>();

            var nameList = new List<string>()
                { "Lamia", "Nabila", "Tithi", "Rifat", "Rifat", "Piyal", "Azim", "Zabed", "Tofazzal", "Sadia", "Sadia", "Jannat" };

            var numberList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 3, 5};

            foreach(var name in nameList )
            {
                hashSetFriendsName.Add( name );
            }

            foreach( var number in numberList )
            {
                hashSetNumber.Add( number );
            }

            foreach(var name in hashSetFriendsName)
            {
                Console.WriteLine( name );
            }

            foreach(var number in hashSetNumber)
            {
                Console.WriteLine(number.ToString());
            }

            hashSetNumber.Remove(3);
            hashSetNumber.Remove(5);
            hashSetFriendsName.Remove("Sadia");
            hashSetFriendsName.Remove("Rifat");

            foreach (var name in hashSetFriendsName)
            {
                Console.WriteLine(name);
            }

            foreach (var number in hashSetNumber)
            {
                Console.WriteLine(number.ToString());
            }

            var hashSetProgrammingLanguageNames = new HashSet<string>() { "C#", "Python", "Java", "Ruby", "C++" };

            hashSetFriendsName.UnionWith(hashSetProgrammingLanguageNames);

            foreach(var itme in hashSetFriendsName)
            {
                Console.WriteLine(itme.ToString());
            }

            hashSetFriendsName.ExceptWith(hashSetProgrammingLanguageNames);
            Console.WriteLine("Printing without programming language name.");
            foreach (var itme in hashSetFriendsName)
            {
                Console.WriteLine(itme.ToString());
            }

            hashSetProgrammingLanguageNames.ExceptWith(hashSetFriendsName);
            Console.WriteLine("Printing without friends names");
            foreach (var itme in hashSetProgrammingLanguageNames)
            {
                Console.WriteLine(itme.ToString());
            }
        }
    }
}
