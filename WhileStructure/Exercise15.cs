namespace ExercisesCS.WhileStructure
{
    public class Exercise15
    {
        private string _validPassword = "2001";

        public void ExecutionExercise() {
            Console.WriteLine("Descubra a senha...");
            Console.WriteLine("Digite a senha: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite algo.");
                return;
            }


            while (userInput != _validPassword)
            {
                Console.WriteLine("Senha incorreta. Tente novamente.");
                Console.WriteLine("Digite a senha: ");
                userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite algo.");
                    continue;
                }
            }

            Console.WriteLine("Senha correta. Acesso concedido.");
        }
    }
}
