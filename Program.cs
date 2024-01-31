using System;

namespace FunctionalProgrammingExample
{
    class Program
    {
        static int globalValue = 10;

        public static int AddAndMultiply(int a, int b)
        {
            return (a + b) * globalValue;
        }
        public static int GenerateRandomNumber(Random random)
        {
            return random.Next();
        }

        public static int PureAdd(int a, int b)
        {
            return a + b;
        }
        public static int ApplyFunction(int value, Func<int, int> func)
        {
            return func(value);
        }
        static void Main(string[] args)
        {
            // 1. Immutability (constant variables)
            const int initialValue = 10;
            Console.WriteLine($"Initial Value: {initialValue}");

            // 2. Function Composition

            Func<int, int> addTwo = x => x + 2;
            Func<int, int> multiplyByThree = x => x * 3;
            Func<int, int> composedFunction = x => multiplyByThree(addTwo(x));
            Console.WriteLine("Result: " + composedFunction(initialValue));

            // 3. Deterministic Functions
            int deterministicResult = AddAndMultiply(3, 4);
            Console.WriteLine("Deterministic Result: " + deterministicResult);

            // 4. Non-deterministic Functions
            Random random = new Random();
            int nonDeterministicResult = GenerateRandomNumber(random);
            Console.WriteLine("Non-deterministic Result: " + nonDeterministicResult);


            // 5. Pure Functions
            int pureFunctionResult = PureAdd(5, 7);
            Console.WriteLine("Pure Function Result: " + pureFunctionResult);

            // 6. Higher-order Functions
            Func<int, Func<int, int>, int> applyFunction = ApplyFunction;
            int higherOrderResult = applyFunction(3, x => x * x);
            Console.WriteLine("Higher-order Function Result:" + higherOrderResult);

        }
    }
}

