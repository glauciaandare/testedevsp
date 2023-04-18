namespace Fibonacci {
    internal class Program {
        static void Main(string[] args)
        {

            Console.Write("Digite o numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int numeroA = 0;
            int numeroB = 1;
            int temp;

            while (numeroB < numero)
            {
                temp = numeroA;
                numeroA = numeroB;
                numeroB = temp + numeroB;
            }

            if (numeroB == numero)
            {
                Console.WriteLine(numero + " pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine(numero + " não pertence à sequência de Fibonacci.");
            }
        }
    }
    
}