using System.Text.RegularExpressions;
/*
4.Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
 
- Dica
    
    💡 Você pode fazer uma verificação e incrementar o contador apenas **`se`** for um caractere, ignorando os espaços caso o usuário digite mais que uma palavra, por exemplo.
    
*/
namespace CSharpFund.desafios;
public class Desaf4
{
    public Desaf4()
    {
        int hora = DateTime.Now.Hour;
        var saudacoes = new string[] { "Boa madrugada", "Bom dia", "Boa tarde", "Boa noite" };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{saudacoes[hora / 6]}, Digite uma ou mais palavras:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Beep(440, 950);
        Console.Beep(660, 950);
        var frase = Console.ReadLine();
        frase = frase.Replace("  ", " ").Replace("  ", " ").Replace("  ", " ").Replace("  ", " ").Replace("  ", " ").Replace("  ", " ").Replace("  ", " ")
            .Replace("\t\t", "\t").Replace("\t\t", "\t").Replace("\t\t", "\t").Replace("\t\t", "\t")
            .Trim();
        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
        string[] palavras = frase.Split(delimiterChars);
        int npalavras = palavras.Length;
        int nesptab = Regex.Matches(frase, "[\\s]").Count;
        int ncaracteres = Regex.Matches(frase, "[A-Za-zÀ-ú0-9-$@#&*()!%+=_<>/\\|.,;:]").Count;


        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Olá, [");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(frase);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("] tem \n - ");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(ncaracteres);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(" Caracteres sem contar espaco ou tabulacoes \n - ");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(nesptab);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(" Espacos ou tabulacoes (retirado os excessos) \n - ");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(npalavras);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(" palavras \n - ");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(nesptab + ncaracteres);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(" Total \n");
        Console.ResetColor();
        Console.WriteLine("Fim do Programa " + GetType().Name+".");
        Console.ReadKey();
    }
}
