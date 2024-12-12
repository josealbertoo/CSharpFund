using System.Text.RegularExpressions;
/*
 * 5. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números; 
    
    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.
 */

namespace CSharpFund.desafios;
public class Desaf5
{
    public Desaf5()
    {
        int hora = DateTime.Now.Hour;
        var saudacoes = new string[] { "Boa madrugada", "Bom dia", "Boa tarde", "Boa noite" };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{saudacoes[hora / 6]}, Digite uma ou mais Placas para validarmos:");
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
        string placaantiga = "[A-z]{3}[-]?\\d{4}\\s";
        string mercosul = "[A-z]{3}[-]?\\d[A-j0-9]\\d{2}\\s";
        Match match;
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Olá, abaixo resultado da Análise:\n" );
        int ncont = 0;
        foreach (var palavra in palavras)
        {
            ncont++;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("*[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(palavra);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("]\t - Placa Antiga ");
            match = Regex.Match(palavra + " ", placaantiga, RegexOptions.Multiline);
            if (match.Success)
            { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t Verdadeiro \t ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t Falso \t\t ");
            }
            Console.Write("\t - Placa Mercosul ");
            match = Regex.Match(palavra + " ", mercosul, RegexOptions.Multiline);
            if (match.Success)
            { 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\t Verdadeiro \t ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t Falso \t\t ");
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n");
        }

        
        Console.ResetColor();
        Console.WriteLine("Fim do Programa " + GetType().Name+".");
        Console.ReadKey();
    }
}
