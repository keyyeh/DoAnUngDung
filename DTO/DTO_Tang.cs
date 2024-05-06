using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Tang
    {
        private string maTang, lau;

        public DTO_Tang()
        {

        }
        public DTO_Tang(string maTang, string lau)
        {
            this.maTang = maTang;
            this.lau = lau;
        }

        public string MaTang { get => maTang; set => maTang = value; }
        public string Lau { get => lau; set => lau = value; }
    }
}
