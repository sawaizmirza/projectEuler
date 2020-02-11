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

        public virtual void ShowAnswer()
        {
            Console.WriteLine($"\nImplement answer func");
        }
    }

    class MultipleOf3And5 : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class EvenFibonacci : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class LargestPrime : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class LargestPalindrome : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class SmallestMultiple : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class SumSquareDifference : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class TenThousandAndFirstPrime : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class LargestInASeries : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class SpecialPythagorean : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class SummationOfPrimes : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class LargestProductInAGrid : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class HighlyDivisibleNumber : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class LargeSum : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class LongestCollatzSequence : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class LatticePaths : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class PowerDigitSum : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class NumberLetterSum : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class MaxPathSumOne : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class CountingSundays : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class FactorialDigitSum : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class AmicableNumbers : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class NamesScores : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class NonAbundantSums : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class LexicographicPermutations : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }

    class ThousandDigitFibNumber : Problem
    {
        public override void ShowAnswer()
        {
            // calc and write answer to console
        }
    }
}
