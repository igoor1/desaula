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
            Console.WriteLine("Nome do Paciente:");

            lista[0] = new pessoa();
            lista[0].nome = Console.ReadLine();
            Console.WriteLine("cpf do paciente");
            lista[0].cpf = Console.ReadLine();
        }
    }
}
