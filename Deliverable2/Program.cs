using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string option1 = "hello";
            string option2 = "bye";
            string option3 = "sup";
            string option4 = "hello there";

            Console.WriteLine("Hi there! Please say something nice to the bot!");

            string input = Console.ReadLine();
            input.ToLower();

            string input2;

            bool repeat = true;

            while (repeat == true)
            {
                botSays();
            }

            void botSays()
            {
                if (input == option1)
                {
                    Console.WriteLine("Hi good to see you");
                }
                else if (input == option2)
                {
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                    return;
                }
                else if (input == option3)
                {
                    Console.WriteLine("I am good");
                }
                else if (input == option4)
                {
                    Console.WriteLine("General Kenobi");
                }

                Console.WriteLine("Please say something else to the bot!");
                input2 = Console.ReadLine();
                
                while (input2 == input)
                {
                    Console.WriteLine("I'm sorry but you've already said that, please try something else.");
                    input2 = Console.ReadLine();
                }

                input = input2;
                input.ToLower();

            }

        }
        
    }    
}
