
//Console Application?
//Dictionary List or employee IDs and names?
//Ask user for their ID and return their name?



Dictionary<int, string> employeeIDs  = new Dictionary<int, string>();

employeeIDs[01] = "Justin Spencer";
employeeIDs[50] = "Ray Cooper";
employeeIDs[60] = "John Fritts";
employeeIDs[64] = "Amanda Spencer";

Console.Write("What is your employee ID? ");
//Convert.ToInt32(Console.ReadLine());
int.TryParse(Console.ReadLine(), out int employeeID);

Console.WriteLine($"Your name is {employeeIDs[employeeID]}");
