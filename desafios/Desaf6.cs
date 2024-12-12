using System.Globalization;
namespace CSharpFund.desafios;
/*  6. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
  - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
  - Apenas a data no formato "01/03/2024".
  - Apenas a hora no formato de 24 horas. 
  - A data com o mês por extenso.
  */

public class Desaf6
{
    protected static bool lsai = false;
    protected static int orileft;
    protected static int oritop;

    public Desaf6()
    {
        int hhora = DateTime.Now.Hour;
        var saudacoes = new string[] { "Boa madrugada", "Bom dia", "Boa tarde", "Boa noite" };
        ConsoleKeyInfo cki;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{saudacoes[hhora / 6]}, digite <Enter> para sair..");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Beep(440, 950);
        Console.Beep(660, 950);
        var (orileft, oritop) = Console.GetCursorPosition();
        do
        {            
            while (!Console.KeyAvailable)
                Relogio(); // Loop 
            cki = Console.ReadKey(true);
        } while (cki.Key != ConsoleKey.Enter);



        Console.ResetColor();
        Console.WriteLine("Fim do Programa " + GetType().Name+".");
        Console.ReadKey();
    }
    private ConsoleKeyInfo Relogio()
    {
            DateTime adt = DateTime.Now;
            CultureInfo culture = new CultureInfo("PT-BR", false);
            Console.SetCursorPosition(70, 0);
            Console.WriteLine(adt.ToString("dddd, dd MMMM yyyy HH:mm:ss", culture));
            Console.SetCursorPosition(70, 1);
            Console.WriteLine(adt.ToString("d", culture));
            Console.SetCursorPosition(70, 2);
            Console.WriteLine(adt.ToString("HH:mm:ss", culture));
            Console.SetCursorPosition(70, 3);
            Console.WriteLine(adt.ToString("dd MMMM yyyy", culture));

            Thread.Sleep(1000); // Pause por 1 segundos
        return new ConsoleKeyInfo(' ', ConsoleKey.Spacebar, false, false, false);
    }
}
