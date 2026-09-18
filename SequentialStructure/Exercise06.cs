using System.Globalization;

namespace ExercisesCS.SequentialStructure
{
    public class Exercise06
    {
        private float _valueA = 0;
        private float _valueB = 0;
        private float _valueC = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("Cálculo de áreas: ");

            Console.WriteLine("Digite os valores A, B e C respectivamente(Dividindo nos espaços): ");
            var input = Console.ReadLine().Split(" ");
            _valueA = float.Parse(input[0], CultureInfo.InvariantCulture);
            _valueB = float.Parse(input[1], CultureInfo.InvariantCulture);
            _valueC = float.Parse(input[2], CultureInfo.InvariantCulture);

            var triangleArea = CalculateTriangleArea(_valueA, _valueC);
            var circleArea = CalculateCircleArea(_valueC);
            var trapezoidArea = CalculateTrapezoidArea(_valueA, _valueB, _valueC);
            var squareArea = CalculateSquareArea(_valueB);
            var rectangleArea = CalculateRectangleArea(_valueA, _valueB);

            Console.WriteLine($"Área do triângulo: {triangleArea.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do círculo: {circleArea.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do trapézio: {trapezoidArea.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do quadrado: {squareArea.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área do retângulo: {rectangleArea.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private float CalculateTriangleArea(float a, float c)
        {
            return (a * c) / 2;
        }

        private float CalculateCircleArea(float c)
        {
            return 3.14159f * c * c;
        }

        private float CalculateTrapezoidArea(float a, float b, float c)
        {
            return ((a + b) * c) / 2;
        }

        private float CalculateSquareArea(float b)
        {
            return b * b;
        }

        private float CalculateRectangleArea(float a, float b)
        {
            return a * b;
        }
    }
}
