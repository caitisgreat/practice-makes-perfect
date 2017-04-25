using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect.HashTable
{
    public class HashTable
    {
        private const int TABLE_SIZE = 15;
        private HashNode[] _HashTable;

        public HashTable()
        {
            _HashTable = new HashNode[TABLE_SIZE];
        }

        private int HashFunction(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentException("Provide a key to hash");
            }

            int hash = 0;
            foreach (char c in key)
            {
                hash = hash + c;
            }

            return hash;
        }

        public void Add (string key, Object value)
        {
            int hash = HashFunction(key);
            int index = hash % TABLE_SIZE;

            if(_HashTable[index] == null)
            {
                // no collision
                _HashTable[index] = new HashNode(key, value);
            }
            else
            {
                // collision detected
                HashNode node = _HashTable[index];
                while (node.next != null)
                {
                    node = node.next;
                }
                node.next = new HashNode(key, value);
            }
        }

        public HashNode Get (string key)
        {
            int hash = HashFunction(key);
            int index = hash % TABLE_SIZE;

            HashNode node = _HashTable[index];
            if(node != null)
            {
                // iterate through nodes at index, assuming any potential collisions
                while (node.next != null)
                {                    
                    // check for key
                    if (node.key == key)
                        break;

                    node = node.next;
                }

                if (node.key == key)
                    return node;
            }

            return null;
        }

        public HashNode[] GetTable ()
        {
            return _HashTable;
        }
    }
}
