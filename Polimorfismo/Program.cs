using Polimorfismo.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Polimorfismo {
    class Program {
        static void Main(string[] args) {

            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Digite o numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Dados do #{i} funcionario: ");
                Console.Write("Funcionario terceirizado (s/n) ?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 's') {
                    Console.Write("Despesa adicional: ");
                    double despesa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, despesa));
                }
                else {
                    lista.Add(new Funcionario(nome, horas, valorPorHora));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS");
            foreach(Funcionario func in lista)
                Console.WriteLine(func.Nome + " - R$ " + func.Pagamento().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
