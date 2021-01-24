using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_2020.Model
{
    public class oderTam
    {
        private string phoneNumber;
        private string codeStaff;
        private string codeBranch;
        private List<Dish> dishes;

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string CodeStaff { get => codeStaff; set => codeStaff = value; }
        public string CodeBranch { get => codeBranch; set => codeBranch = value; }

        public oderTam(string phoneNumber, string codeStaff, string codeBranch)
        {
            this.phoneNumber = phoneNumber;
            this.codeStaff = codeStaff;
            this.codeBranch = codeBranch;
            this.dishes = new List<Dish>();
        }

        public List<Dish> Dishes()
        {
            return this.dishes;
        }

        public void addDish(string code,string price,string toal )
        {
            Dish dish = new Dish(code, price, toal);
            this.dishes.Add(dish);
        }
        public int checkoutCodDish(string code)
        {
            return this.dishes.FindIndex(e => e.CodeDish == code);
        }
    }
}
