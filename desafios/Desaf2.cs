namespace CSharpFund.desafios;
/*
2. Crie um programa que concatene um nome e um sobrenome  inseridos pelo usuário e ao final exiba o nome completo.
*/
public class Desaf2
{
    public Desaf2()
    {
        int hora = DateTime.Now.Hour;
        var saudacoes = new string[] { "Boa madrugada", "Bom dia", "Boa tarde", "Boa noite" };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{saudacoes[hora / 6]}, digite seu nome:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Beep(440, 950);
        Console.Beep(660, 950);
        var nome = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("agora, digite seu sobrenome:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Beep(440, 950);
        Console.Beep(660, 950);
        var sobrenome = Console.ReadLine();

        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Olá, ");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(nome+" "+sobrenome);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("! Seja muito bem - vindo!\n");
        Console.ResetColor();
        Console.WriteLine("Fim do Programa " + GetType().Name+".");
        Console.ReadKey();
    }
}
