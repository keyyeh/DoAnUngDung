using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Tang
    {
        private int id;
        private string lau;

        public DTO_Tang()
        {

        }
        public DTO_Tang(string lau)
        {
            this.lau = lau;
        }

        public DTO_Tang(int id, string lau)
        {
            this.id = id;
            this.lau = lau;
        }

        public string Lau { get => lau; set => lau = value; }
        public int Id { get => id; set => id = value; }
    }
}
