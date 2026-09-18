namespace ExercisesCS.SequentialStructure
{
    public class Exercise09
    {
        private int _number1 = 0;
        private int _number2 = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("--- Valores múltiplos ---");

            Console.Write("Digite o primeiro número: ");
            _number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            _number2 = Convert.ToInt32(Console.ReadLine());

            if (IsMultiple(_number1, _number2)) { 
                Console.WriteLine($"{_number1} é múltiplo de {_number2}");
            }

            if (IsMultiple(_number2, _number1)) { 
                Console.WriteLine($"{_number2} é múltiplo de {_number1}");
            }

            if (!IsMultiple(_number1, _number2) && !IsMultiple(_number2, _number1)) { 
                Console.WriteLine($"{_number1} e {_number2} não são múltiplos um do outro");
            }
        }

        private bool IsMultiple(int number1, int number2)
        {
            if (number1 % number2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
