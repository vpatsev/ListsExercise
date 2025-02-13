using System.ComponentModel;

List<int> numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToList();

string command = Console.ReadLine();

while(command != "end")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];

    switch (commandName)
    {
        case "Add":
            int numsToAdd = int.Parse(commandParts[1]); 
            numbers.Add(numsToAdd);break;
        case "Remove": 
            int numsToRemove = int.Parse(commandParts[1]);
            numbers.Remove(numsToRemove);break;
        case "RemoveAt":
            int numsToRemoveAt = int.Parse(commandParts[1]);
            numbers.RemoveAt(numsToRemoveAt);break;
        case "Insert":
            int numsToInsert = int.Parse(commandParts[1]);
            int positionToInsert  = int.Parse(commandParts[2]);  
            numbers.Insert(positionToInsert,numsToInsert);break;

    }    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ",numbers));