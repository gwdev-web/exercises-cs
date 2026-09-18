

namespace ExercisesCS.SequentialStructure
{
    public class Exercise07
    {
        private int _value = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("Descubra se um número é positivo ou negativo");

            Console.WriteLine("Digite um número: ");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Entrada inválida. Não aceitamos valores nulos ou vazios, digite um número inteiro.");
                return;
            }

            _value = int.Parse(input);

            if (_value > 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else if (_value < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}
