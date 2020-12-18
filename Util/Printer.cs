using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer 
    {
        public static void DibujaLinea(int tam = 10)
        {                        
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle()
        {
            WriteLine();
        }
    }
}
