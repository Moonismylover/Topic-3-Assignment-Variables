namespace Topic_3___Assignment__Variables_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Angel 

            Console.Title = "Topic 3 - Assignment (Variables)";

            string courseName, fullName;
            int roomNumber, gradYear;
            double price, radius, areaCircle, baseTriangle, heightTriangle, areaTriangle;

            roomNumber = 29;
            price = 2.99;
            courseName = "Computer Science";

            Console.WriteLine("This is room #" + roomNumber + ".");
            Console.WriteLine(" ");
            Console.WriteLine("The price is " + price.ToString("C") + ".");
            Console.WriteLine("");
            Console.WriteLine("I am learning a bit about " + courseName + "!");
            Console.WriteLine(" ");

            fullName = "Angelpreet K. Thind";
            gradYear = 2027;

            Console.WriteLine("Hey! My name is " + fullName + " and I'll graduate in " + gradYear + ".");
            Console.WriteLine(" ");

            Console.WriteLine("Hey! What radius would you like to use for the circle?");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");

            areaCircle = Math.PI * 2 * radius;
            Console.WriteLine("The area of a circle with the radius of " + radius.ToString("F2") + " is " + areaCircle.ToString("F2") + ".");
            Console.WriteLine(" ");

            // .ToString("F#") = Decimal Places
            // Convert.ToDouble() = Converts user input to double

            // My favorite mathematical formula would be the area of a triangle.

            Console.WriteLine("Let's calculate the area of a triangle!");
            Console.WriteLine(" "); 
            Console.WriteLine("Please enter the base: ");
            baseTriangle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Please enter the height: ");
            heightTriangle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");

            areaTriangle = 0.5 * baseTriangle * heightTriangle;

            Console.WriteLine("The area of the triangle is " + areaTriangle.ToString("F2") + "!");

        }
    }
}
