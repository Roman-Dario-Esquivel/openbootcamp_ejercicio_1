namespace openbootcamp_introducion_programacion_1
{
    class Program
    {
        static void Main()
        {
            int num1, num2, num3;
            num1 = 3;
            num2 = 2;
            num3 = 5;
            

            Console.WriteLine("el resultado de la suma de 3 numeros enteros es: " + suma3_NUM(num1, num2, num3));
        }

        public static int suma3_NUM(int NUM1, int NUM2, int NUM3)
        {
            Console.WriteLine("numero 1 a sumar es: " + NUM1);
            Console.WriteLine("numero 2 a sumar es: " + NUM2);
            Console.WriteLine("numero 3 a sumar es: " + NUM3);
            int sum = NUM1 + NUM2 + NUM3;
            return sum;
         }
    }
}