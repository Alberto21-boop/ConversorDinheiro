using ConversorDinheiro;

Moeda moeda;

List<Moeda>moedas = new List<Moeda>();

string[] lista = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//cambio.txt");
//string[] lista = System.IO.File.ReadAllLines(@"C:\Users\Alber\Desktop\cambio.txt");

foreach (string line in lista)
{
    string[] vet = line.Split(' ');
    moeda = new Moeda(vet[0], double.Parse(vet[1]));
    moedas.Add(moeda);
}

Console.WriteLine("Menu de Moedas & Seus Valores");

foreach(Moeda moed in moedas)
{
    Console.WriteLine(moed);
}

Console.WriteLine("Entre com o valor que você deseja converter:");
Console.Write("Valor desejado ");
double Pegavalor = double.Parse(Console.ReadLine());

Console.WriteLine("Qual a moeda ou nascionalidade da moeda que você tem ?");
Console.Write("Sua moeda: ");
string SuaMoeda = Console.ReadLine();

Console.WriteLine("Qual o tipo de moeda para conversão ?");
Console.Write("Tipo da Moeda ");
string TipoMoeda = Console.ReadLine();

for(var i = 0; i < moedas.Count; i++)
{
    if(SuaMoeda == moedas[i].NomeMoeda)
    {
        for(var j = 0; j < moedas.Count; j++)
        {
            if(TipoMoeda == moedas[j].NomeMoeda)
            {
                Console.WriteLine($"Valor da conversão = {moedas[j].ValorMoeda} {((moedas[j].ValorMoeda / moedas[j].ValorMoeda) * Pegavalor).ToString("C")}");
            }
        }
    }
}



    