using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructures
{
    public  interface IEmailService
    {

        public static void SendManagerEmail();


        public static void SendAdminEmail();



        public static void SendSecurityEmail();


        public static void SendHREmail();


        public static void SendStaffEmail();
        

    }
}
