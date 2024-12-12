namespace CSharpFund.desafios;
/*
3. Crie um programa com 2 valores do tipo**`double`** já declarados**** que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números; 
    - A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.

    💡 Você pode ir além e permitir que o usuário insira dois números aleatórios!
    
*/
public class Desaf3
{
    public Desaf3()
    {
        int hora = DateTime.Now.Hour;
        var saudacoes = new string[] { "Boa madrugada", "Bom dia", "Boa tarde", "Boa noite" };
        string csolicitacao = "1o número";
        //double dnum = 0;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{saudacoes[hora / 6]}, vamos fazer uma experiência, digite o {csolicitacao}:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Beep(440, 120);
        Console.Beep(660, 220);
        double dnum1 = LerNumeros(0,false);


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("agora, digite o 2o número:");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Beep(440, 120);
        Console.Beep(660, 220);
        double dnum2 = LerNumeros(0,true);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("-A soma entre esses dois números: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(SomDouble(dnum1, dnum2).ToString() + "\n");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("-A subtração entre os dois números: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(SubDouble(dnum1, dnum2).ToString() + "\n");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("-A multiplicação entre os dois números: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(MultDouble(dnum1, dnum2).ToString() + "\n");
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("-A divisão entre os dois números: ");
        if (dnum2 == 0)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nao é possível fazer divisao devido o 2o numero ser 0.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(DivDouble(dnum1, dnum2).ToString() + "\n");
        }
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("-A média entre os dois números: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(MediaDouble(dnum1, dnum2).ToString() + "\n");

        Console.ResetColor();
        Console.WriteLine("Fim do Programa " + GetType().Name+".");
        Console.ReadKey();
    }



    static double LerNumeros(double dnum, bool l2onum)
    {   
        bool ldouble= false;
        Console.ResetColor();
        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            var cnum = Console.ReadLine();
            ldouble = double.TryParse(cnum, result: out dnum);
            if (!ldouble)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Número informado não é um número Double válido, tente digitar um numero.");
            }
            if (dnum == 0 && l2onum)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("o 2o numero nao pode ser zero.");
            }
        }
        while (!ldouble|| (dnum == 0 && l2onum));
        return dnum;
    }
    static double SomDouble(double x, double y)
    {
        return x + y;
    }
    static double SubDouble(double x, double y)
    {
        return x - y;
    }
    static double MultDouble(double x, double y)
    {
        return x * y;
    }
    static double DivDouble(double x, double y)
    {
        if (y == 0)
            return 0;
        else
            return x / y;
    }
    static double MediaDouble(double x, double y)
    {
        return (x + y)/2;
    }

}
