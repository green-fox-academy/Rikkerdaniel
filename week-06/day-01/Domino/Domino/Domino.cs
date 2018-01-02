using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    class Domino :IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(object DominoToCompare)
         {
             int returnNumber = 0;
             if (DominoToCompare is Domino)
             {
                 if ((DominoToCompare as Domino).Values[0] < Values[0])
                 {
                     returnNumber = 1;
                 }
                 else if((DominoToCompare as Domino).Values[0] > Values[0])
                 {
                     returnNumber = -1;
                 }
                 else
                 {
                     if ((DominoToCompare as Domino).Values[1] < Values[1])
                     {
                         returnNumber = 1;
                     }
                     else if ((DominoToCompare as Domino).Values[1] > Values[1])
                     {
                         returnNumber = -1;
                     }
                     else
                     {
                         returnNumber = 0;
                     }
                 }                
             }
             return returnNumber;
         }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
