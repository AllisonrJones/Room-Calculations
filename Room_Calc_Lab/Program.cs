Console.WriteLine("Welcome to the classroom calculator template. Please enter the length of your room");
decimal length = decimal.Parse(Console.ReadLine());

Console.WriteLine("Now please enter the width of your room");
decimal width = decimal.Parse(Console.ReadLine());

decimal perimeter = 2 * length + 2 * width;


Console.WriteLine("Thank you for your input. The area of your classroom is equal to " + length * width + " and the perimeter of your class room is equal to " + perimeter);

decimal area = length * width;

if (area <= 250)
{
    Console.WriteLine("Your space is considered a small room");

}
if (area >250 && area <650)
{
    Console.WriteLine("Your space is considered a medium sized room");

}

if (area >650)
{
    Console.WriteLine("Your space is considered a large sized room");

}

Console.WriteLine("If you would like to know the volume of your space please enter the height of your walls");
decimal height = decimal.Parse(Console.ReadLine());

Console.WriteLine("The volume of your room is equal to " + length * width * height);
decimal surfaceArea = 2*(length * width) + 2*(length * height) + 2*(height * width);

Console.WriteLine("It may also interest you to know the surface area of your space is " + surfaceArea);

Console.WriteLine("Thank you for participating in our room calculations");


