using DesafioAula8;

string mensagem = "";

try
{
    Console.WriteLine("Seja bem vindo ao cadastro de contas bancarias");

    List<ContaBancaria> listacontas = new List<ContaBancaria>();


    for (int contagem =  1; contagem <= 3; contagem++)
    {

        Console.WriteLine("CADASTRE UMA NOVA CONTA");

        Console.WriteLine($"Digite o tipo {contagem}");
        string tipoconta = Console.ReadLine();

        Console.WriteLine($"Digite o numrero da conta {contagem}");
        int numeroconta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Digite a agência {contagem}");
        int agenciaconta = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Qual o saldo {contagem}");
        double saldoconta = Convert.ToDouble(Console.ReadLine());

        ContaBancaria contaBancaria = new ContaBancaria(tipoconta, numeroconta, agenciaconta, saldoconta);

        listacontas.Add( contaBancaria );
    }

    Console.WriteLine("Qual numero de conta você gostaria de ver?");
    int numerocontabusca = Convert.ToInt32(Console.ReadLine());



    if (listacontas.Where(conta => conta.Numero == numerocontabusca).Any())
    {
        ContaBancaria contaBancariaBusca = listacontas.Where(conta => conta.Numero == numerocontabusca).FirstOrDefault();
        mensagem = contaBancariaBusca.ExibirDadosConta();
    }
    else
    {
        mensagem = "Essa conta não existe";
    }
    

    
}
catch (Exception ex)
{
    mensagem = "O erro encontrado no sistema foi " + ex.Message;
}
finally
{
    Console.WriteLine(mensagem);
}