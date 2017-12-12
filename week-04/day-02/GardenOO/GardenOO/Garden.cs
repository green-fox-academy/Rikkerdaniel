using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenOO
{
    class Garden
    {
        List<Flower> flowers = new List<Flower>();
        List<Tree> trees = new List<Tree>();

        public void AddFlower(Flower flower )
        {
            flowers.Add(flower );
        }
        public void AddTree(Tree tree)
        {
            trees.Add(tree);
        }
    }
}
