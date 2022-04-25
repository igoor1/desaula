using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desaula
{
    class atendimento
    {
        pessoa[] lista = new pessoa[10];

        public void cadastro()
        {
           for(int i=0; i < 10; i++)
            {
                Console.WriteLine("Nome do Paciente:");
                lista[i] = new pessoa();
                lista[i].nome = Console.ReadLine();
                Console.WriteLine("cpf do paciente");
                lista[i].cpf = Console.ReadLine();
                Console.WriteLine("sexo do paciente");
                lista[i].sexo = Console.ReadLine();
            }
        }
    }
}
