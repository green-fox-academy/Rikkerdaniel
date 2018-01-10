using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaBank.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public float Balance { get; set; }
        public string Currency { get; set; }
        public string  AnimalType { get; set; }
        public bool IsKing { get; set; }
    }
}
