using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_2020.Model
{
    public class SelecetedDish
    {
        private string code;
        private string sdtCustomer;
        private string codeStaff;
        private string codeBranch;
        private DateTime date;
        private string totalPrices;

        public SelecetedDish(string code, string sdtCustomer, string codeStaff, string codeBranch, DateTime date, string totalPrices)
        {
            this.code = code;
            this.sdtCustomer = sdtCustomer;
            this.codeStaff = codeStaff;
            this.codeBranch = codeBranch;
            this.date = date;
            this.totalPrices = totalPrices;
        }

        public string Code { get => code; set => code = value; }
        public string SdtCustomer { get => sdtCustomer; set => sdtCustomer = value; }
        public string CodeStaff { get => codeStaff; set => codeStaff = value; }
        public string CodeBranch { get => codeBranch; set => codeBranch = value; }
        public DateTime Date { get => date; set => date = value; }
        public string TotalPrices { get => totalPrices; set => totalPrices = value; }
    }
}
