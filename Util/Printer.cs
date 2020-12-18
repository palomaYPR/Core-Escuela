using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer 
    {
        public static void DibujaLinea(int tam = 10)
        {                        
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string title)
        {
            var tamanio = title.Length + 4;
            DibujaLinea(tamanio);
            WriteLine($"| {title} |");
            DibujaLinea(tamanio);
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int repeticion = 1)
        {
            while (repeticion-- > 0) 
            {
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}
