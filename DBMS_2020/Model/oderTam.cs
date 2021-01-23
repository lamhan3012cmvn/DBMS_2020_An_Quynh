using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_2020.Model
{
    class oderTam
    {
        private string phoneNumber;
        private string codeStaff;
        private string codeBranch;
        private List<Dish> dishes;

        public oderTam(string phoneNumber, string codeStaff, string codeBranch)
        {
            this.phoneNumber = phoneNumber;
            this.codeStaff = codeStaff;
            this.codeBranch = codeBranch;
            this.dishes = new List<Dish>();
        }
    }
}
