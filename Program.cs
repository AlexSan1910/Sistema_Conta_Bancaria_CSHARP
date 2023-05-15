using ExercicioBancario;

namespace Course{
    class Program
    {
        static void Main(string[] args){

            // Instanciando os novos objetos

            ContaBancaria conta1 = new ContaBancaria();
            ContaBancaria conta2 = new ContaBancaria();
            Random randomicoConta = new Random();
            Random randomicoSaldo = new Random();

            // Definindo dados CONTA1

            Console.WriteLine("Vamos Cadastrar uma nova conta sua? ");

            conta1.Numero = randomicoConta.Next(100); // definindo um numero randomico para a conta do user de até no maximo 100
            Console.WriteLine($"O numero da sua conta é {conta1.Numero}");
            Console.Write("Digite o seu nome de titular que deseja: ");
            conta1.Titular = Console.ReadLine();
            conta1.Saldo = randomicoSaldo.Next(2000); // Definindo um numero randomico para o saldo do user até 2000 mil 
            Console.WriteLine($"O seu Saldo atual é de {conta1.Saldo}\n");

            // Definindo dados CONTA2

            Console.WriteLine("Vamos Cadastrar sua segunda Conta? ");

            conta1.Numero = randomicoConta.Next(100); // definindo um numero randomico para a conta do user de até no maximo 100
            Console.WriteLine($"O numero da sua segunda conta é {conta1.Numero}");
            Console.Write("Digite o seu nome de titular que deseja: ");
            conta2.Titular = Console.ReadLine();
            conta2.Saldo = randomicoSaldo.Next(2000); // Definindo um numero randomico para o saldo do user até 2000 mil 
            Console.WriteLine($"O seu Saldo atual da sua segunda conta é de {conta1.Saldo}\n");

            // partindo para as operações

            Console.WriteLine("Vamos agora para as operações: ");
            bool condicao = true;

            while(condicao == true){
                // Menu de operações 

                Console.WriteLine(Environment.NewLine + "Digite qual opção deseja fazer em sua conta!!");
                Console.WriteLine("1 - Sacar.");
                Console.WriteLine("2 - Depositar.");
                Console.WriteLine("3 - Tranferir.");
                Console.Write("4 - Sair do Programa.\n");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if(opcao == 1){
                    Console.WriteLine(Environment.NewLine + "Digite o valor que deseja sacar");
                    decimal saque = Convert.ToDecimal(Console.ReadLine());
                    conta1.Sacar(saque);
                    Console.WriteLine($"\nApós esse saque seu saudo agora é de {conta1.ConsultarSaldoAtual()}");
                } else if (opcao == 2){
                    Console.WriteLine(Environment.NewLine + "Digite o valor que deseja Depositar");
                    decimal deposito = Convert.ToDecimal(Console.ReadLine());
                    conta1.Depositar(deposito);
                    Console.WriteLine(Environment.NewLine + $"Após esse deposito seu saldo atua é {conta1.ConsultarSaldoAtual()}");
                    conta1.ConsultarSaldoAtual();
                }else if (opcao == 3){
                    Console.WriteLine(Environment.NewLine + "Digite o valor que deseja Transferir e o nome da conta");
                    decimal transferencia = Convert.ToDecimal(Console.ReadLine());
                    conta1.Transferencia(conta2, transferencia);
                    Console.WriteLine(Environment.NewLine + $"Após essa tranferencia o saldo da sua Conta 1 é de {conta1.ConsultarSaldoAtual()}");
                    Console.WriteLine(Environment.NewLine + $"Sendo assim a sua Conta 2 após a transferencia tem o saldo de {conta2.ConsultarSaldoAtual()}");
                } else {
                    condicao = false;
                }
            }


        
        }
    }
}