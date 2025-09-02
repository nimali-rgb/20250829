

namespace MainApp;


internal static class MenuService
{
    private static string _option = "";
    private static List<string> _namelist = [];
    public static void DisplayListView(List<string> name_list)
    {
        Console.WriteLine("---- Name List ----");
        foreach (string name in name_list)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();
    }

    public static void AddNameList(List<string> name_list)
    {
        Console.WriteLine("Add To List");
        Console.Write("Ange ett namn: ");
        string input_name = Console.ReadLine()!;

        if (!string.IsNullOrWhiteSpace(input_name))
        {
            name_list.Add(input_name);
        }
    }

    public static void MenuOption()
    {
        Console.Clear(); //rensar menyn så det inte blir en hel rad med meny varje gång

        Console.WriteLine("-----MENY OPTION-----");
        Console.WriteLine("1. View list");
        Console.WriteLine("2. Add To List");
        Console.WriteLine("0. Exit Application");

        Console.Write("\nChoose one option: "); // (\n) gör en rad bryting
        string _option = Console.ReadLine()!;

        Console.Clear();
    }
    public static void MainMenu()
    {
        List<string> name_list = name_list = [];
        do
        {
            DisplayListView(name_list);
           

            switch (_option)
            {
                case "1":
                    DisplayListView(name_list);
                    break;

                case "2":
                    AddNameList(name_list);
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
    }

   
}
   

