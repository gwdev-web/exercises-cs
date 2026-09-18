namespace ExercisesCS.SequentialStructure
{
    public class Exercise08
    {
        private int _value = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("--- Par ou ímpar ---");

            Console.WriteLine("Digite o número para descobrirmos: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Entrada inválida. Não aceitamos valores nulos ou vazios, digite um número inteiro.");
                return;
            }

            _value = int.Parse(input);

            if (_value % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}
