using System.Globalization;

namespace ExercisesCS.SequentialStructure
{
    public class Exercise14
    {
        private double _salary = 0.0;

        public void ExecutionExercise()
        {
            Console.WriteLine("--- Cálculo do imposto de renda ---");
            Console.WriteLine("Digite o salário: ");
            _salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double tax;
            if (_salary <= 2000.0)
            {
                tax = 0.0;
            }
            else if (_salary <= 3000.0)
            {
                tax = (_salary - 2000.0) * 0.08;
            }
            else if (_salary <= 4500.0)
            {
                tax = (_salary - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                tax = (_salary - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (tax == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
