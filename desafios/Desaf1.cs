using System.Runtime.Intrinsics.X86;

namespace CSharpFund.desafios;
  /*  1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  **`Olá, Welisson! Seja muito bem-vindo!`**

    * Obs: veja que o método para ler os dados que um usuário digita não foi passado em aula.*
    O que acha de começar com a sua primeira busca? 🔍 

    Caso não encontre, vou deixar uma dica aqui embaixo! 
        - Dica 👀
        
        
            💡 O método para ler os dados que um usuário digita é o **`Console.ReadLine();`**
    */

public class Desaf1
{
    public Desaf1()
    {
        int hora = DateTime.Now.Hour;
        var saudacoes = new string[] { "Boa madrugada", "Bom dia", "Boa tarde", "Boa noite" };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{saudacoes[hora / 6]}, digite seu nome:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Beep(440, 950);
        Console.Beep(660, 950);
        var nome = Console.ReadLine();

        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Olá, ");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(nome);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("! Seja muito bem - vindo!\n");
        Console.ResetColor();
        Console.WriteLine("Fim do Programa " + GetType().Name+".");
        Console.ReadKey();
    }
}
