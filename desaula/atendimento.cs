using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desaula
{
    class atendimento
    {
        public string nome, cpf, sexo, prioridade;
        atendimento[] lista = new atendimento[9];


        public void registrar()
        {
            Console.WriteLine("Nome do Paciente:");
           nome = Console.ReadLine();
            lista[0] = nome;
        }
    }
}
