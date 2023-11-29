namespace conditions_task_no_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //od największej do najmniejszej wartości
            //posłem, premierem: 21, senatorem: 30, prezydentem: 35

        Console.WriteLine("Podaj swój wiek");

            string ageInput = Console.ReadLine();
            int age;

            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine("Konwersja wieku udała się.");

                if (age >= 35)
                {
                    Console.WriteLine("Masz wybór, możesz zostać: posłem, premierem, senatorem a nawet prezydentem.");
                }

                else if (age >= 30)
                {
                    Console.WriteLine("Możesz zostać posłem, premierem oraz senatorem.");
                }
                else if (age >= 21)
                {
                    Console.WriteLine("Możesz zostać posłem, premierem.");
                }

                else
                {
                    Console.WriteLine("Błąd. Nie wprowadziłeś wieku lub jesteś za młody na pisatowanie stanowiska urzędniczego.");
                }
            }
            else
            {
                Console.WriteLine("Błąd. Nie wprowadziłeś wieku lub jesteś za młody na pisatowanie stanowiska urzędniczego.");
            }
        }
    }
}
