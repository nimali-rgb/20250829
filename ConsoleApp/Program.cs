


List<string> name_List = [];

Console.WriteLine("Hej och välkommen. ");
string answer = "";

do
{
    Console.Write("ange ditt namn: ");

    string input_name = Console.ReadLine()!;

    if (!string.IsNullOrEmpty(input_name))
    {
        name_List.Add(input_name);
    }

    Console.Write("Vill du ange ett nytt namn? y/n:  ");
    answer = Console.ReadLine()!;
}
while (answer == "y"); //med true i så blir den för evigt loop


Console.Clear();


Console.WriteLine("##NANMNLISTA##");

foreach (string name in name_List)
{
    Console.WriteLine(name);
}


Console.ReadKey();