internal class Program
{

    static double Depositar(double saldoAtual, double valorDeposito)
    {


        saldoAtual = saldoAtual + valorDeposito;

        return saldoAtual;
    }

    static double Sacar(double saldoAtual, double valorSaque)
    {

        if (saldoAtual >= valorSaque)
        {
            saldoAtual = saldoAtual - valorSaque;
            return saldoAtual;
        }

        else
        {
            Console.WriteLine("Saldo insuficiente.");
            return saldoAtual;
        }
    }

    static void MostrarSaldo(double saldoAtual)
    {
        Console.WriteLine($"Seu saldo atual é: {saldoAtual}");
    }
    private static void Main(string[] args)
    {
        int escolha;
        double saldoAtual, deposito, saque = 0;

        Console.WriteLine("Informe o seu saldo: ");
        saldoAtual = double.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("Qual opção você deseja escolher?");
            Console.WriteLine("--- Menu ---\n 1 - Depositar \n 2 - Sacar \n 3 - Ver saldo \n 0 - Sair");
            escolha = int.Parse(Console.ReadLine());


            if (escolha == 1)
            {
                Console.WriteLine("Quanto você deseja depositar?");
                deposito = double.Parse(Console.ReadLine());
                saldoAtual = Depositar(saldoAtual,deposito);
                MostrarSaldo(saldoAtual);
            }

            else if (escolha == 2)
            {
                Console.WriteLine("Quanto você deseja sacar?");
                saque = double.Parse(Console.ReadLine());
                saldoAtual = Sacar(saldoAtual, saque);
                MostrarSaldo(saldoAtual);
            }
            else if (escolha == 3)
            {
                MostrarSaldo(saldoAtual);
            }
        } while (escolha != 0);
    }
}