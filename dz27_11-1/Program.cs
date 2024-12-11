namespace dz27_11_1
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    public class Array : ICalc
    {
        public int[] elements;

        public Array(int[] elements)
        {
            this.elements = elements;
        }

        public int Less(int valueToCompare)
        {
            return elements.Count(e => e < valueToCompare);
        }

        public int Greater(int valueToCompare)
        {
            return elements.Count(e => e > valueToCompare);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayData = { 1, 2, 3, 4, 5 };
            Array myArray = new Array(arrayData);

            Console.WriteLine("Масивчик: " + string.Join(", ", arrayData));

            int uyt = 5;
            Console.WriteLine($"елементів менших за {uyt}: {myArray.Less(uyt)}");
            Console.WriteLine($"більших за {uyt}: {myArray.Greater(uyt)}");
        }
    }
}
