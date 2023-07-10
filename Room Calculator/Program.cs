Console.WriteLine("Enter Length:");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Width: ");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Height: ");
double height = double.Parse(Console.ReadLine());
double area = length * width;
double perimeter = (length * 2) + (width * 2);
double volume = (length * width * height);
double surfaceArea = 2 * ((length * width) + (length * height) + (height * width));
Console.WriteLine($"Area: {area}");
Console.WriteLine($"Perimeter: {perimeter}");
Console.WriteLine($"Volume: {volume}");
Console.WriteLine($"Surface area: {surfaceArea}");
if (area <= 250)
{
    Console.WriteLine("This is a small room.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This is a medium-sized room.");
 }
else if (area >= 650)
{
    Console.WriteLine("This is a large room.");
}

Console.WriteLine("Thank you for using the Room Detail Generator!");
