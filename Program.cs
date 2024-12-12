using CSharpFund.desafios;
namespace CSharpFund;
class Program
{
    protected static List<string> menus = [ "1º Desafio (Nome)",
                                            "2º Desafio (Nome e Sobrenome)",
                                            "3º Desafio (2 Números + operações matemáticas)",
                                            "4º Desafio (Palavras e quantos  caracteres, sem o espaco)",
                                            "5º Desafio (Validacao de Placa formato antigo)",
                                            "6º Desafio (Datas em formatos)"];
    public static bool saveCursorVisible;

    protected static int nponteiro=0;


    public static void Main()
    {
        ConsoleKeyInfo cki;
        saveCursorVisible = Console.CursorVisible;


        Console.CursorVisible = false;
        Console.Clear();
        

        foreach (var menu in menus.Select((x, i) => new { Index = i, Value = x }) )
        {
            if (menu.Index== nponteiro)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{menu.Value}");
                Console.ResetColor();
            }
            else
                Console.WriteLine($"{menu.Value}");
        }
        Console.WriteLine("\n<Enter> Seleciona <Esc> para sair..");
        try
        {
            Console.SetCursorPosition(0, 0);
            
            do
            {
                cki = Console.ReadKey(true);
                var (left, top) = Console.GetCursorPosition();
                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (top > (menus.Count - 1))
                            top = (menus.Count - 1);
                        if (top > 0)
                        {
                            Console.WriteLine($"{menus[nponteiro]}");
                            Console.SetCursorPosition(
                                    left, top-1);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            nponteiro = top-1;
                            Console.WriteLine($"{menus[top-1]}");
                            Console.SetCursorPosition(
                                    left, top - 1);
                            Console.ResetColor();
                        }
                        else
                            Console.SetCursorPosition(
                                    left, nponteiro);
                        break;
                    case ConsoleKey.UpArrow:
                        if (top > (menus.Count - 1))
                            top = (menus.Count - 1);
                        if (top > 0)
                        {
                            Console.WriteLine($"{menus[nponteiro]}");
                            Console.SetCursorPosition(
                                    left, top-1);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            nponteiro = top-1;
                            Console.WriteLine($"{menus[top-1]}");
                            Console.SetCursorPosition(
                                    left, top - 1);
                            Console.ResetColor();
                        }
                        else
                            Console.SetCursorPosition(
                                    left, nponteiro);
                        break;
                    case ConsoleKey.RightArrow:
                        if (top < (menus.Count-1))
                        {
                            Console.WriteLine($"{menus[nponteiro]}");
                            Console.SetCursorPosition(
                                    left, top + 1);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            nponteiro = top + 1;
                            Console.WriteLine($"{menus[top + 1]}");
                            Console.SetCursorPosition(
                                    left, top + 1);
                            Console.ResetColor();
                        }
                        else
                            Console.SetCursorPosition(
                                    left, nponteiro);
                        break;
                    case ConsoleKey.DownArrow:
                        if (top < (menus.Count-1))
                        {
                            Console.WriteLine($"{menus[nponteiro]}");
                            Console.SetCursorPosition(
                                    left, top + 1);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            nponteiro = top + 1;
                            Console.WriteLine($"{menus[top+1]}");
                            Console.SetCursorPosition(
                                    left, top + 1);
                            Console.ResetColor();
                        }
                        else
                            Console.SetCursorPosition(
                                    left, nponteiro);
                        break;
                }
            }
            while (cki.Key != ConsoleKey.Escape && cki.Key != ConsoleKey.Enter);  // end do-while
            if (cki.Key == ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = saveCursorVisible;
                Console.Clear();
                int noption = nponteiro;
                nponteiro = 0;
                switch (noption)
                {
                    case 0:
                        _ = new Desaf1();

                        Main();
                        break;
                    case 1:
                        _ = new Desaf2();
                        Main();
                        break;
                    case 2:
                        _ = new Desaf3();
                        Main();
                        break;
                    case 3:
                        _ = new Desaf4();
                        Main();
                        break;
                    case 4:
                        _ = new Desaf5();
                        Main();
                        break;
                    case 5:
                        _ = new Desaf6();
                        Main();
                        break;
                    default:
                        Console.WriteLine("Opção " + nponteiro.ToString() + " não disponível ");
                        Main();
                        break;

                }

            }
            else
            {
                Console.SetCursorPosition(1, menus.Count + 2);
            }

        } // end try
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.CursorVisible = saveCursorVisible;

        }    
    }
 }

