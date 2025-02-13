int numCommands = int.Parse(Console.ReadLine());

List<string> commands = new List<string>();

for (int i = 0; i < numCommands; i++)
{
    string[] currentCmd = Console.ReadLine()
                         .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                         .ToArray();
    string name = currentCmd[0];

    if (currentCmd.Length == 3)
    {
        if (commands.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
            continue;
        }
        commands.Add(name);
    }
    else if (currentCmd.Length == 4)
    {
        if (!commands.Contains(name))
        {
            Console.WriteLine($"{name} is not in the list!");
            continue;
        }
        commands.Remove(name);
    }
}
foreach (string name in commands)
{
    Console.WriteLine(name);
}


//int n = int.Parse(Console.ReadLine());  
//List<string> guestList = new List<string>();

//for (int i = 0; i < n; i++)
//{
//    string[] currentCmd = Console.ReadLine()
//                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
//                             .ToArray();

//    string name = currentCmd[0];

//    if (currentCmd.Length == 3)
//    {
//        if (guestList.Contains(name))
//        {
//            Console.WriteLine($"{name} is already in the list!");
//            continue;
//        }
//        guestList.Add(name);
//    }
//    else if (currentCmd.Length == 4) {

//        if (!guestList.Contains(name))
//        {
//            Console.WriteLine($"{name} is not in the list!");
//            continue;   
//        } guestList.Remove(name);
//    } 
//} 
//  foreach (string guest in guestList)
//{
//    Console.WriteLine(guest);
//}

