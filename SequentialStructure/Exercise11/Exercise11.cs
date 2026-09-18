namespace ExercisesCS.SequentialStructure.Exercise11
{
    public class Exercise11
    {

        public void ExecutionExercise() {
            var cachorroQuente = new Food(1, "Hot Dog", 4.00);
            var xSalada = new Food(2, "X-Salada", 4.50);
            var xBacon = new Food(3, "X-Bacon", 5.00);
            var torradaSimples = new Food(4, "Torrada simples", 2.00);
            var refrigerante = new Food(5, "Refrigerante", 1.50);

            Console.WriteLine("Digite o código do produto (1-5):");
            uint code = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade: ");
            uint quantity = Convert.ToUInt32(Console.ReadLine());

            double totalPrice = code switch
            {
                1 => cachorroQuente._Price * quantity,
                2 => xSalada._Price * quantity,
                3 => xBacon._Price * quantity,
                4 => torradaSimples._Price * quantity,
                5 => refrigerante._Price * quantity,
                _ => 0.0
            };
            Console.WriteLine($"Total a pagar: R$ {totalPrice:F2}");
        }
    }
}
