using ExercisesCS.SequentialStructure.Exercise11;

namespace ExercisesCS.SequentialStructure.Exercise11
{
    internal class Food : IFood
    {
        public uint _Id { get; set; }

        public string _Specification { get; set; }

        public double _Price { get; set; }

        public Food(uint id, string specification, double price)
        {
            _Id = id;
            _Specification = specification;
            _Price = price;
        }
    }
}
