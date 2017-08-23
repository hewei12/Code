using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StractoryLoginCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            PwdCredential pc = new PwdCredential();
            pc.UserName = "test01";
            pc.Password = "123456";
            UserLogin ul = new UserPwdLogin();
            ul.Login(pc);

            CardCredential cc = new CardCredential();
            cc.Card = "NK001";
            UserLogin um = new UserCardLogin();
            um.Login(cc);
            
        }
    }
}
