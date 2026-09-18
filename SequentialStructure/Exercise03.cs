namespace ExercisesCS.SequentialStructure
{
    public class Exercise03
    {
        private int _a = 0;
        private int _b = 0;
        private int _c = 0;
        private int _d = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("--- Diferença de produtos ---");
            Console.WriteLine("Fórmula: (A * B - C * D)");

            Console.WriteLine("Digite o valor de A: ");
            _a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            _b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            _c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            _d = int.Parse(Console.ReadLine());

            int result = DifferenceOfProducts(_a, _b, _c, _d);
            Console.WriteLine($"Resultado: {result}");
        }

        private int DifferenceOfProducts(int a, int b, int c, int d)
        {
            return (a * b) - (c * d);
        }
    }
}
