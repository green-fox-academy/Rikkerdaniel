using RestApifirstEx.Models;
using RestApifirstEx.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApifirstEx.Services
{
    public class LogService
    {

        public LogService(LogRepository logRepository)
        {
            LogRepository = logRepository;
        }

        public LogRepository LogRepository { get; set; }

        public int? Doubling (int? input)
        {
            LogRepository.AddToDatabase("/doubling", input.ToString());
            return input*2;
        }

        public string Greeter(string name , string title)
        {
            LogRepository.AddToDatabase("/greet", name+title);
            return "Oh, hi there " + name + ", my dear " + title + "!";
        }

        public string AppendA(string append)
        {
            LogRepository.AddToDatabase("/appenda",append);
            return append + "a";
        }

        public int DoUntilSum(Item input)
        {
            LogRepository.AddToDatabase("/dountil/sum", input.ToString());
            int sum = 0;
            for (int i = 1; i < input.until + 1; i++)
            {
                sum += i;
            }
            return sum;
        }

        public int DoUntilFactor(Item input)
        {
            LogRepository.AddToDatabase("/dountil/factor", input.ToString());
            int fact = 0;
            for (int i = 1; i < input.until + 1; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public int ArrayMultiply(int[] item)
        {
            LogRepository.AddToDatabase("/arrays", item.ToString());
            int multi = 1;
            for (int i = 0; i < item.Length; i++)
            {
                multi = item[i] * multi;
            }
            return multi;
        }

        public int[] ArrayDouble(int[] item )
        {
            LogRepository.AddToDatabase("/arrays", item.ToString());
            for (int i = 0; i < item.Length; i++)
            {
                item[i] = item[i] * 2;
            }
            return item;
        }
    }
}
