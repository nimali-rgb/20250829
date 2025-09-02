
List<string> name_list = new List<string>();

bool isRunning = true;
do
{
    Console.Clear(); //rensar menyn så det inte blir en hel rad med meny varje gång

    Console.WriteLine("-----MENY OPTION-----");
    Console.WriteLine("1. View list");
    Console.WriteLine("2. Add To List");
    Console.WriteLine("0. Exit Application");

    Console.Write("\nChoose one option: "); // (\n) gör en rad bryting
    string option = Console.ReadLine()!;

    /*if (option == "1")
    {

    }
    else if (option == "0") 
    {
    
    }*/
    Console.Clear();

    switch (option)
    {
        case "1":
            Console.WriteLine("View list");
            foreach (string name in name_list)
            { 
                Console.WriteLine(name); 
            }
            Console.ReadKey();
            break;

        case "2":
            Console.WriteLine("Add To List");
            Console.Write("Ange ett namn: ");
            string input_name = Console.ReadLine()!;
            if (!string .IsNullOrWhiteSpace(input_name))
            {
                name_list.Add(input_name);
            }
            break;

        case "0":
            Environment.Exit(0);
            break;

        default:
            break;
    }
    Console.Clear();
}
while (true);