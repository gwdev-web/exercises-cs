using System.Globalization;

namespace ExercisesCS.SequentialStructure
{
    public class Exercise05
    {
        private int _codePiece1 = 0;
        private int _quantityPiece1 = 0;
        private double _pricePiece1 = 0.0;
        private int _codePiece2 = 0;
        private int _quantityPiece2 = 0;
        private double _pricePiece2 = 0.0;
        public void ExecutionExercise() {
            Console.WriteLine("Total do valor das peças:");

            Console.WriteLine("Digite o código da peça 1, quantidade e o seu preço respectivamente(Dividindo em espaço): ");
            var input1 = Console.ReadLine().Split(" ");

            _codePiece1 = int.Parse(input1[0]);
            _quantityPiece1 = int.Parse(input1[1]);
            _pricePiece1 = double.Parse(input1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da peça 2, quantidade e o seu preço respectivamente(Dividindo em espaço): ");
            var input2 = Console.ReadLine().Split(" ");

            _codePiece2 = int.Parse(input2[0]);
            _quantityPiece2 = int.Parse(input2[1]);
            _pricePiece2 = double.Parse(input2[2], CultureInfo.InvariantCulture);

            var result = TotalPricePieces(_quantityPiece1, _pricePiece1, _quantityPiece2, _pricePiece2);

            Console.WriteLine($"Valor a pagar: {result:F2}");
        }

        private double TotalPricePieces(int quantityPiece1, double pricePiece1, int quantityPiece2, double pricePiece2) {
            var totalPiece1 = pricePiece1 * quantityPiece1;
            var totalPiece2 = pricePiece2 * quantityPiece2;

            return totalPiece1 + totalPiece2;
        }
    }
}
