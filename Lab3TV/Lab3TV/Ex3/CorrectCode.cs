using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    class CorrectCode
    {
        public string Code { get; set; }
        public string Role { get; set; }

        public CorrectCode(string code, string role)
        {
            this.Code = code;
            this.Role = role;
        }
    }
}
