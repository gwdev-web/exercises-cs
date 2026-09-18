using System.Text.RegularExpressions;

namespace ExercisesCS.SequentialStructure
{
    public class Exercise10
    {
        private uint _startHour = 0;
        private uint _endHour = 0;

        public void ExecutionExercise()
        {
            Console.WriteLine("--- Cálculo da duração de um jogo ---");

            Console.WriteLine("Digite a hora de início do jogo (0-23): ");
            var inputStartHour = Console.ReadLine();

            Console.WriteLine("Digite a hora de término do jogo (0-23): ");
            var inputEndHour = Console.ReadLine();

            if (string.IsNullOrEmpty(inputStartHour) || string.IsNullOrEmpty(inputEndHour))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite valores válidos para as horas.");
                return;
            }

            if (Regex.IsMatch(inputStartHour.Trim(), @"^\s*-") || Regex.IsMatch(inputEndHour.Trim(), @"^\s*-"))
            {
                Console.WriteLine("Entrada inválida. Valores negativos não são permitidos.");
                return;
            }

            _startHour = uint.Parse(inputStartHour);
            _endHour = uint.Parse(inputEndHour);

            if (_endHour > _startHour)
            {
                Console.WriteLine($"O jogo durou {_endHour - _startHour} hora(s)");
            }

            if (_endHour < _startHour)
            {
                Console.WriteLine($"O jogo durou {(_endHour + 24) - _startHour} hora(s)");
            }

            if (_startHour == _endHour)
            {
                Console.WriteLine("O jogo durou 24 hora(s)");
            }

            if (_startHour > 23 || _endHour > 23)
            {
                Console.WriteLine("Entrada inválida. As horas devem estar entre 0 e 23.");
            }
        }
    }
}