using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_TTTA_01.Class
{


    public class AccountCheck
    {
        public string TypeAccount(string TkString)
        {
            string accountTypeString = TkString;
            AccountType accountType;
            if (Enum.TryParse(accountTypeString, true, out accountType))
            {
                return accountType.ToString();
            }
            return "";

        }

    }

}
    

 

