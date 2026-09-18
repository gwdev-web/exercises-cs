namespace ExercisesCS.WhileStructure
{
    public class Exercise17
    {
        public void ExecutionExercise()
        {
            int alcohol = 0;
            int gasoline = 0;
            int diesel = 0;
            int code = 0;

            Console.WriteLine("Digite o código do combustível (1.Álcool 2.Gasolina 3.Diesel 4.Fim):");

            while (code != 4)
            {
                if (int.TryParse(Console.ReadLine(), out code))
                {
                    if (code == 1)
                    {
                        alcohol++;
                    }
                    else if (code == 2)
                    {
                        gasoline++;
                    }
                    else if (code == 3)
                    {
                        diesel++;
                    }
                    else if (code != 4)
                    {
                        Console.WriteLine("Código inválido. Por favor, insira um código válido (1 a 4):");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcohol);
            Console.WriteLine("Gasolina: " + gasoline);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
