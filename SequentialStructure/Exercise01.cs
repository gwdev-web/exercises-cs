namespace ExercisesCS.SequentialStructure
{
    public class Exercise01
    {
        private double _value1 = 0;
        private double _value2 = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("--- Soma de dois valores ---");

            Console.WriteLine("Digite o primeiro valor");
            _value1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            _value2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A soma dos valores é: {_value1 + _value2}");
        }
    }
}
