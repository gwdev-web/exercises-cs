namespace ExercisesCS.WhileStructure
{
    public class Exercise16
    {
        private int _valueX = 0;
        private int _valueY = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("--- Coordenadas ---");

            Console.WriteLine("Digite os eixos X e Y: ");
            string[] inputs = Console.ReadLine().Split(' ');

            if (inputs.Length != 2 || string.IsNullOrEmpty(inputs[0]) || string.IsNullOrEmpty(inputs[1]))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite dois valores separados por um espaço.");
                return;
            }

            _valueX = int.Parse(inputs[0]);
            _valueY = int.Parse(inputs[1]);

            while (_valueX != 0 || _valueY != 0)
            {
                if (float.IsPositive(_valueX) && float.IsPositive(_valueY))
                    Console.WriteLine("Primeiro Quadrante");

                if (float.IsNegative(_valueX) && float.IsPositive(_valueY))
                    Console.WriteLine("Segundo Quadrante");

                if (float.IsNegative(_valueX) && float.IsNegative(_valueY))
                    Console.WriteLine("Terceiro Quadrante");

                if (float.IsPositive(_valueX) && float.IsNegative(_valueY))
                    Console.WriteLine("Quarto Quadrante");

                Console.WriteLine("Digite os eixos X e Y: ");
                inputs = Console.ReadLine().Split(' ');

                if (inputs.Length != 2 || string.IsNullOrEmpty(inputs[0]) || string.IsNullOrEmpty(inputs[1]))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite dois valores separados por um espaço.");
                    return;
                }

                _valueX = int.Parse(inputs[0]);
                _valueY = int.Parse(inputs[1]);
            }
        }
    }
}
