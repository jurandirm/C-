using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Modelos{

public class Usuario
    {
        public string? Nome { get; set;}
        public string? Email { get; set; }

        public string? ObterLogin()
        {
            string[] emailSplit = Email.Split('@');
            //Console.WriteLine(emailSplit[0]);
            return "Olá " + Nome + " seu login de rede é: " + emailSplit[0];
        }
    }
}