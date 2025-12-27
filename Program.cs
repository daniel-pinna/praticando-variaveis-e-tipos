using System.Formats.Asn1;

void desafioIdadeAtual()
{
    Console.Write("Por favor, informe o seu ano de nascimento: ");
    int anoNascimento = int.Parse(Console.ReadLine()!);
    byte idadeAtual = (byte) (DateTime.Now.Year - anoNascimento);
    Console.WriteLine($"Sua idade atual é {idadeAtual} anos");
}

void desafioDoacao()
{
    bool doacaoAnonima;
    Console.Write("Por favor, informe o valor que deseja doar: ");
    float valorDoado = float.Parse(Console.ReadLine()!);

    Console.Write("Sua doação será anônima? Informe A para anônima ou I para identificada: ");
    char tipoDoacao = char.Parse(Console.ReadLine()!);

    if (tipoDoacao == 'A')
    {
        doacaoAnonima = true;
    } else
    {
        doacaoAnonima = false;
    }

    Console.Write("Sua doação será para qual tipo de conta? Informe P para conta poupança ou C para conta corrente: ");
    char tipoConta = char.Parse(Console.ReadLine()!);

    Console.WriteLine($"\nValor recebido: R${valorDoado}");
    Console.WriteLine($"Doação anônima: {doacaoAnonima}");
    Console.WriteLine($"Tipo de conta: {tipoConta}");
}

void desafioCalculoDistancias()
{
    Console.Write("Por favor, informe a distância em milhas: ");
    double distanciaMilhas = double.Parse(Console.ReadLine()!);

    double distanciaKM = distanciaMilhas * 1.60934;
    Console.WriteLine($"A distância informada em milhas, equivalem a {distanciaKM} Km");
}

void desafioConverterMminutosParaHorasEMinutos()
{
    Console.Write("Por favor, a quantidade total de minutos: ");
    int totalMinutos = int.Parse(Console.ReadLine()!);

    TimeSpan tempo = TimeSpan.FromMinutes(totalMinutos);
    int horas = tempo.Hours;
    int minutosRestantes = tempo.Minutes;

    Console.WriteLine($"Tempo {horas} e {minutosRestantes} minuto(s)");
}

void desafioCalculoAreaRetangulo()
{
    double largura = 10.5; 
    double comprimento = 20.3; 

    double area = largura * comprimento;
    Console.WriteLine($"A área do terreno é: {area} metros quadrados");
}

void desafioMediaDeNotasEscolares()
{
    float n1 = 7.2F;
    float n2 = 8.3F;
    float n3 = 9.1F;

    float media = (n1 + n2 + n3) / 3;
    Console.WriteLine($"A média das notas é: {media}");
}

void desafioConversaoDeTipo()
{
    decimal pesoContainer = 18.75m; 
    int veiculosNecessarios = (int)pesoContainer;  //truncamento

    Console.WriteLine("Veículos necessários: " + veiculosNecessarios); 
}

void desafioGameLifeWithIncrementAndDecrement()
{
    int totalVidas = 5;
    totalVidas--;
    totalVidas++;
    totalVidas++;

    Console.WriteLine("Vidas finais: " +totalVidas); 
}

void desafioCalculoAumentoSalarial()
{
    decimal salarioAtual = 1500.0m; 
    decimal percentualAumento = 10.0m; 
    decimal novoSalario = salarioAtual + (salarioAtual * percentualAumento/100);

    Console.WriteLine($"O novo salário é de: R${novoSalario.ToString("F2")}"); 
}

void desafioCalculoAreaEPerimetro()
{
    double pi = 3.14159; 
    double raio = 5.0; 
    double area = pi * raio * raio;
    double perimetro = 2 * pi * raio;

    Console.WriteLine($"Raio: {raio.ToString("F2")}"); 
    Console.WriteLine($"Área do círculo: {area.ToString("F2")}"); 
    Console.WriteLine($"Perímetro do círculo: {perimetro.ToString("F2")}"); 
}
// desafioIdadeAtual();
// desafioDoacao();
// desafioCalculoDistancias();
// desafioConverterMminutosParaHorasEMinutos();
// desafioCalculoAreaRetangulo();
// desafioMediaDeNotasEscolares();
// desafioConversaoDeTipo();
// desafioGameLifeWithIncrementAndDecrement();
// desafioCalculoAumentoSalarial();
desafioCalculoAreaEPerimetro();