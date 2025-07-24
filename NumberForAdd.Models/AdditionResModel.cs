using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberForAdd.Models
{
    public class AdditionResModel
    {
        private int _sum; //This is a private prop t
        public AdditionResModel(int sum) { 
        _sum = sum;
        }

        public int GetSum()
        {
            return _sum; //this return sum
        }
    }
}
