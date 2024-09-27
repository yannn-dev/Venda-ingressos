using System.Data;

namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            int quantidadeIngressos = 0;
            double valorTotal = 0;
            double valorTotalFinal = 0;
            int ingressosTotal = 0;
            double desconto = 0;
            

            List<Ingressos> historico = new List<Ingressos>();

            Ingressos ingressoNormal = new Ingressos();
            ingressoNormal.Nome = "Normal";
            ingressoNormal.Preco = 20;
            Ingressos ingressoMeia = new Ingressos();
            ingressoMeia.Nome = "Meia-entrada";
            ingressoMeia.Preco = 10;
            Ingressos ingressoVip = new Ingressos();
            ingressoVip.Nome = "VIP";
            ingressoVip.Preco = 35;

            do
            {
                Console.Clear();
                Console.WriteLine("\t==========Menu de vendas==========");
                Console.WriteLine("\nEscolha a opção que desejar:");
                Console.WriteLine("1. Comprar ingressos");
                Console.WriteLine("2. Visualizar histórico de transações");
                Console.WriteLine("3. Sair");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Escolha a opção do ingresso que desejar:");
                    Console.WriteLine("1. Normal - R$20,00");
                    Console.WriteLine("2. Meia-entrada - R$10,00");
                    Console.WriteLine("3. VIP - R$35,00");
                    int ingresso = int.Parse(Console.ReadLine());

                    Console.Write("\nDigite a quantidade de ingressos desejados: ");
                    quantidadeIngressos = int.Parse(Console.ReadLine());

                    switch (ingresso)
                    {
                        case 1:
                            historico.Add(ingressoNormal);
                            Console.WriteLine("\nQuantidade de ingressos: " + quantidadeIngressos);                  
                            valorTotal = ingressoNormal.Preco * quantidadeIngressos;
                            Console.WriteLine("Valor total: R$" + valorTotal);
                            break;
                        case 2:
                            historico.Add(ingressoMeia);
                            Console.WriteLine("\nQuantidade de ingressos: " + quantidadeIngressos);
                            valorTotal = ingressoMeia.Preco * quantidadeIngressos;
                            Console.WriteLine("Valor total: R$" + valorTotal);
                            break;
                        case 3:
                            historico.Add(ingressoVip);
                            Console.WriteLine("\nQuantidade de ingressos: " + quantidadeIngressos);
                            valorTotal = ingressoVip.Preco * quantidadeIngressos;
                            Console.WriteLine("Valor total: R$" + valorTotal);
                            break;
                    }

                    ingressosTotal += quantidadeIngressos;                  

                    if (ingressosTotal >= 5)
                    {
                        Console.WriteLine("\nParabéns! Você acaba de ganhar um desconto de 5% por comprar 5 ingressos ou mais!");
                        desconto = (valorTotal / 100) * 5; 
                        valorTotal -= desconto;
                        Console.WriteLine("Total a pagar (com desconto): R$" + valorTotal);

                    }

                    if (valorTotal >= 100)
                    {
                        Console.WriteLine("\nParabéns! Você acaba de ganhar um desconto de 10% por fazer compras acima de R$100,00!");
                        desconto = (valorTotal / 100) * 10;
                        valorTotal -= desconto;
                        Console.WriteLine("Total a pagar (com desconto): R$" + valorTotal);
                    }

                    valorTotalFinal += valorTotal;

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();

                }
                if(escolha == 2)
                {
                    Console.Clear();
                    foreach (Ingressos ingresso in historico)
                    {
                        Console.WriteLine($"\n{ingresso.Nome}");
                        Console.WriteLine($"R${ingresso.Preco}");
                    }

                    Console.WriteLine("\nValor total: R$" + valorTotalFinal);
                    Console.WriteLine("Quantidade total de ingressos: " + ingressosTotal);
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }

                if (escolha == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Obrigado por escolher os nossos serviços. Volte Sempre!");
                    Console.WriteLine("Pressione qualquer tecla para fechar...");
                    Console.ReadKey();
                }

            } while (escolha != 3);
        }
        public class Ingressos()
        {
            public double Preco { get; set; }
            public string Nome { get; set; }
        }
    }
}
