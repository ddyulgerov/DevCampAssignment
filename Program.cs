using System;

namespace MM_draw
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            for (int i = 0; i < (size + 1) / 2; ++i)
            {
                Dash(size - i);
                Star(size + 2 * i);
                Dash(size - 2 * i);
                Star(size + 2 * i);
                Dash(2 * (size - i));
                Star(size + 2 * i);
                Dash(size - 2 * i);
                Star(size + 2 * i);
                Dash(size - i);

                Console.WriteLine();
            }

            for (int i = (size + 1) / 2; i < size + 1; i++)
            {
                Dash(size - i);
                Star(size);
                Dash(2 * i - size);
                Star(3 * size - 2 * i);
                Dash(2 * i - size);
                Star(size);
                Dash(2 * (size -i));
                Star(size);
                Dash(2 * i - size);
                Star(3 * size - 2 * i);
                Dash(2 * i - size);
                Star(size);
                Dash(size - i);

                Console.WriteLine();

            }

        }
        static void Dash(int count)
        {

            for (int i = 0; i < count; ++i)
            {
                Console.Write("-");
            }
        }

        static void Star(int count)
        {

            for (int i = 0; i < count; ++i)
            {
                Console.Write("*");
            }
        }



    }
}
