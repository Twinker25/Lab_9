namespace Lab_9
{
    //Task 2 delegate
    public delegate double MyDelegate(double a, double b);

    class Program
    {
        //Task 2 functions
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Sub(double a, double b)
        {
            return a - b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a / b;
        }


        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Write("Enter task (1 - 3): ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter letter: ");
                        string let = Console.ReadLine();
                        MyDelegate2 myDelegate2 = Show;
                        myDelegate2(let);
                        break;

                    case 2:
                        double rez;
                        MyDelegate myDelegate = null;
                        Console.Write("\nNum 1: ");
                        double ch1 = int.Parse(Console.ReadLine());
                        Console.Write("Num 2: ");
                        double ch2 = int.Parse(Console.ReadLine());
                        Console.Write("Calculator:\n1 - Add\n2 - Subtract\n3 - Multi\n4 - Divide\nEnter operation: ");
                        int ch = int.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                myDelegate = Add;
                                break;
                            case 2:
                                myDelegate = Sub;
                                break;
                            case 3:
                                myDelegate = Mult;
                                break;
                            case 4:
                                myDelegate = Div;
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        rez = myDelegate(ch1, ch2);
                        Console.WriteLine("Result: {0}", rez);
                        break;

                    case 3:
                        Predicate<int> even = x => x % 2 == 0;
                        Predicate<int> odd = x => x % 2 != 0;
                        Predicate<int> prime = x => Prime(x);
                        Predicate<int> fib = x => Fib(x);

                        int num;
                        Console.Write("Enter number: ");
                        num = int.Parse(Console.ReadLine());

                        if (even(num))
                        {
                            Console.WriteLine(num + " is even");
                        }
                        else
                        {
                            Console.WriteLine(num + " isn't even");
                        }

                        if (odd(num))
                        {
                            Console.WriteLine(num + " is odd");
                        }
                        else
                        {
                            Console.WriteLine(num + " isn't odd");
                        }

                        if (prime(num))
                        {
                            Console.WriteLine(num + " is prime");
                        }
                        else
                        {
                            Console.WriteLine(num + " isn't prime");
                        }

                        if (fib(num))
                        {
                            Console.WriteLine(num + " is Fibonacci");
                        }
                        else
                        {
                            Console.WriteLine(num + " isn't Fibonacci");
                        }
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (choice < 1 || choice > 3);
        }
        //Task 1 function
        public static void Show(string a)
        {
            Console.WriteLine("Result: " + a);
        }


        //Task 3 functions
        static bool Prime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool Fib(int num)
        {
            int a = 0, b = 1, c = 1;
            while (c < num)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c == num;
        }
    }
    //Task 1 delegate
    public delegate void MyDelegate2(string a);
}