using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Answer { get; set; }
        public string Description { get; set; }

        string line = "----------------------------";

        public void ShowMenu()
        {
            Console.WriteLine($"{Number}: {Name}");
        }

        public void ShowDescription()
        {
            Console.WriteLine($"\nProblem {Number}: {Name}");
            Console.WriteLine($"{line}");
            Console.WriteLine($"{Description}");
            Console.WriteLine($"{line}");
            Console.WriteLine($"\nPress enter to see answer.");
            Console.ReadKey();
        }

        // public abstract void ShowAnswer();

        public virtual int ShowAnswer()
        {
            return default;
        }
    }

    class MultipleOf3And5 : Problem
    {
        public override int ShowAnswer()
        {
            int x = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    x += i;
                }
            }
            Console.WriteLine(x);
            Console.ReadKey();
            return x;
        }
    }

    class EvenFibonacci : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class LargestPrime : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class LargestPalindrome : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class SmallestMultiple : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class SumSquareDifference : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class TenThousandAndFirstPrime : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class LargestInASeries : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class SpecialPythagorean : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class SummationOfPrimes : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class LargestProductInAGrid : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class HighlyDivisibleNumber : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class LargeSum : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class LongestCollatzSequence : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class LatticePaths : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class PowerDigitSum : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class NumberLetterSum : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class MaxPathSumOne : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class CountingSundays : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class FactorialDigitSum : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class AmicableNumbers : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class NamesScores : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class NonAbundantSums : Problem
    {
        public override int ShowAnswer()
        {
            return default;

        }
    }

    class LexicographicPermutations : Problem
    {
        public override int ShowAnswer()
        {
            return default;
        }
    }

    class ThousandDigitFibNumber : Problem
    {
        public override int ShowAnswer()
        {
            return default;
        }
    }
}
