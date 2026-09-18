namespace ExercisesCS.SequentialStructure
{
    public class Exercise04
    {
        private int _numberEmployee = 0;
        private double _hoursWorked = 0;
        private double _hourlyRate = 0;
        public void ExecutionExercise()
        {
            Console.WriteLine("--- Cálculo do salário de um funcionário ---");

            Console.WriteLine("Digite o número do funcionário: ");
            _numberEmployee = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas: ");
            _hoursWorked = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            _hourlyRate = double.Parse(Console.ReadLine());

            double salary = CalculateSalary(_hoursWorked, _hourlyRate);
            Console.WriteLine($"Número do funcionário: {_numberEmployee}");
            Console.WriteLine($"Salário: {salary:F2}");
        }

        private double CalculateSalary(double hoursWorked, double hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }
    }
}
