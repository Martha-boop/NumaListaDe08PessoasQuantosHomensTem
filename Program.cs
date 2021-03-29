using System;

namespace NumaListaDe08PessoasQuantosHomensTem
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal quant = 0;
            string sexo = "";
            int i = 0;

            Console.WriteLine("Verificar quantos sexo Masculino!");
           

            while(i < 8)
            {
                i = i + 1;
                Console.WriteLine("Digite o sexo da pessoa!");
                sexo = Console.ReadLine();
                
                if(sexo == "masculino")
                {
                    quant = quant + 1;
                }
            }
            Console.WriteLine("Existem "    + quant+ " pessoas do sexo masculino nesta lista!");

            Console.ReadLine();
        }
        
    }
}
