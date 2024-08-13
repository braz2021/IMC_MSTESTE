using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace imc.mstest
{
    public class IMC
    {
        public double peso;
        public double altura;
        public double imc;
        public string? categoria;

        public void calcular_IMC()
        {
            imc = peso / (altura * altura);
            imc = Math.Round(imc, 2);
        }
        public void classificar_IMC()
        {
            if (imc < 18.5)
            {
               categoria =  "Abaixo do peso"; 
            }
            else if(imc < 25)
            {
                categoria = "peso normal";
            }
            else if(imc < 30)
            {
                categoria = "sobrepeso";
            }
            else if (imc < 35)
            {
                categoria = "obsidade GR 1 ";
            }
            else if ( imc < 40)
            {
                categoria = "obseidade GR 2";
            }
            else
            {
                categoria = "obsediade GR 3";
            }
        }
    }
}