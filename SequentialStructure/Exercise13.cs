namespace ExercisesCS.SequentialStructure
{
    public class Exercise13
    {
        private float _valueX = 0;
        private float _valueY = 0;

        public void ExecutionExercise() {
            Console.WriteLine("Digite o valor do eixo X: ");
            var inputValueX = Console.ReadLine();

            Console.WriteLine("Digite o valor do eixo Y: ");
            var inputValueY = Console.ReadLine();

            if(string.IsNullOrEmpty(inputValueX) || string.IsNullOrEmpty(inputValueY)) {
                Console.WriteLine("Valores inválidos.");
                return;
            }

            _valueX = float.Parse(inputValueX);
            _valueY = float.Parse(inputValueY);

            if (_valueX == 0 && _valueY == 0) {
                Console.WriteLine("Origem");
            } else if (_valueX == 0) {
                Console.WriteLine("Eixo Y");
            } else if (_valueY == 0) {
                Console.WriteLine("Eixo X");
            } else if (_valueX > 0 && _valueY > 0) {
                Console.WriteLine("Q1");
            } else if (_valueX < 0 && _valueY > 0) {
                Console.WriteLine("Q2");
            } else if (_valueX < 0 && _valueY < 0) {
                Console.WriteLine("Q3");
            } else if (_valueX > 0 && _valueY < 0) {
                Console.WriteLine("Q4");
            }
        }
    }
}
