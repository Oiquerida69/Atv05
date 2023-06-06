using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVHj
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;
            string endereço;
            string cidade;
            string estado;
            string bairro;
            int ViagensAp;
            int ViagensEa;
            string cupom;
            string resposta;
            Console.WriteLine("Bem-vindo a empresa de hotelaria e viagens do wendinho");
            Console.WriteLine("digite seu primeiro nome :");
            nome1 = Console.ReadLine();
            Console.WriteLine("digite seu segundo nome :");
            nome2 = Console.ReadLine();
            Console.WriteLine($"Olá ,Sr(a) {nome1} {nome2} , vamos continuar o cadastro ");
            Console.WriteLine("digite seu endereço :");
            endereço = Console.ReadLine();
            Console.WriteLine("Digite sua cidade : ");
            cidade = Console.ReadLine();
            Console.WriteLine("digite seu estado :");
            estado = Console.ReadLine();
            Console.WriteLine("digite seu bairro :");
            bairro = Console.ReadLine();
            Console.WriteLine($"O(a) , Sr(a) {nome2}, mora no endereço {endereço}, na cidade {cidade}-{estado} no bairro {bairro}");
            Console.WriteLine("digite a quantidade de viagens feitas ano passado");
            ViagensAp = Int32.Parse( Console.ReadLine());
            Console.WriteLine("digite a quantidade de viagens você gostaria de fazer esse ano :");
            ViagensEa = Int32.Parse( Console.ReadLine());
            Console.WriteLine($"faltam {10 - (ViagensAp + ViagensEa)} para chegar a 10 viagens");
            Console.WriteLine($"O total de viagens feitas é {ViagensAp + ViagensEa}");
            Console.WriteLine($"A media de viagens feitas é {(ViagensAp + ViagensEa) / 2}");
            Console.WriteLine($"O intervalo de tempo entre as viagens é {12 /(ViagensAp + ViagensEa) }");
            Console.WriteLine($"Obrigado {nome1} {nome2} o cadastro foi feito com sucesso \n ");
            Console.WriteLine("digite o cupom :");
            cupom = Console.ReadLine();
            if (cupom == "Wendinho10")
            {
                Console.WriteLine("Parabens você recebeu 10% de desconto na sua proxima viagem");

            } else {
                Console.WriteLine("Esse cupom não existe");

            }
            Console.WriteLine("você gostaria de receber emails de promoções ?");
            resposta = Console.ReadLine();
            if (resposta == "sim")
            {
                Console.WriteLine("você foi cadastrado com sucesso \n volte sempre");
            } else {
                Console.WriteLine("Okay , tenha um bom dia");
            }
            Console.ReadKey();
        }
    }
}
