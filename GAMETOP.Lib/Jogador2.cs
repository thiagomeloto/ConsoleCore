using GAMETOP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMETOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona estas pateando";
        }

        public string Corre()
        {
            return "Maradona estas corriendo";
        }

        public string Passe()
        {
            return "Maradona estas pasando";
        }
    }
}
