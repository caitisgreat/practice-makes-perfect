using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMakesPerfect.HashTable
{
    public class HashNode
    {
        private int index { get; set; }
        public HashNode (string key, Object value)
        {
            this.key = key;
            this.value = value;
        }

        public string key { get; set; }
        public Object value { get; set; }
        
        public HashNode next { get; set; }
    }
}
