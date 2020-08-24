using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSM_Project
{
    public class redundantData
    {
        public struct empInfo
        {
            public string id, pin, name, contact, address, email, status;
            public empInfo(string s)
            {
                id = pin = name = contact = address = email = status = s;
            }
        }
    }
}
