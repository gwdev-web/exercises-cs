using System;
using System.Globalization;

namespace ExercisesCS.SequentialStructure
{
    public class Exercise02
    {
        private double _pi = 3.14159;
        private double _radius = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("--- Cálculo da área do círculo ---");

            Console.WriteLine("Digite o raio do círculo: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || !TryParseRadius(input, out _radius))
            {
                Console.WriteLine("Entrada inválida. O programa será encerrado.");
                return;
            }

            Console.WriteLine($"A área do círculo é: {CalculateCircleArea(_radius).ToString("F4", CultureInfo.InvariantCulture)}");
        }

        private bool TryParseRadius(string value, out double radius)
        {
            radius = 0;
            var normalized = value.Trim().Replace(',', '.');
            return double.TryParse(normalized, NumberStyles.Float | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture, out radius);
        }

        private double CalculateCircleArea(double radius)
        {
            return _pi * radius * radius;
        }
    }
}