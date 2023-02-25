using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_arreglos_personas_CWF;

namespace App_arreglos_personas_CWF
{
    class Contac
    {
        private String telephone;
        private String gmail;

        public string Telefono
        {
            get { return telephone; }
            set
            {
                telephone = value.Replace(" ", "").Replace("-", "");
            }
        }

        public String Correo
        {
            get { return gmail; }
            set { gmail = value; }
        }

        public Contac()
        {
            telephone = string.Empty;
            gmail = string.Empty;
        }

        public Contac(string telephone, string gmail)
        {
            this.telephone = telephone;
            this.gmail = gmail;
        }

        public override string ToString()
        {
            return "\nTelefono: " + telephone + "\nCorreo: " + gmail;
        }
    }
}