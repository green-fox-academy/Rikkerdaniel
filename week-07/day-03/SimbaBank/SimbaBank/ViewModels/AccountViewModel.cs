using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimbaBank.Models;

namespace SimbaBank.ViewModels
{
    public class AccountViewModel
    {
        public List<BankAccount> AccountList  = new List<BankAccount>();

        public void AddAccount(BankAccount bankAccount)
        {
            AccountList.Add(bankAccount);
        }
    }
}
