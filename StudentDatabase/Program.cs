// See https://aka.ms/new-console-template for more information
Console.WriteLine("============================");
Console.WriteLine("STUDENT DATABASE");
Console.WriteLine("============================");
Console.WriteLine("Welcome!");
bool isValid = true;
string[] name ={
    "Justin Jones",
    "DeAngelo Robinson",
    "Martina Basquez",
    "Alain Rene",
    "David Goodwin",
    "Joey Molinski",
    "Wren Grasley",
    "Brady Hartman",
    "David Brameijer",
    "Afseen Salam",
    "Ethan Thomas"
};

string[] hometowns = {
    "Westerville",
    "Detroit",
    "Edinburg",
    "Homestead",
    "Jersey City",
    "Toledo",
    "Richmond",
    "Saranac",
    "Grand Rapids",
    "India",
    "Bolivar"
    };

string[] favoriteFoods ={
    "Baja Blast",
    "Pizza",
    "Leftovers",
    "Chicken Wings",
    "Sushi",
    "Dill Pickles",
    "Pizza",
    "Chicken Wings",
    "Tacos",
    "Shawarma",
    "Grapes"
    };

while (isValid)
{
 
    int studentNumber = 0;
    int lenght = name.Length;
    Console.WriteLine($"Which student would you like to learn more about? Enter a number 1-{lenght} or Student Name:");
    string? userOption = Console.ReadLine();
    studentNumber = GetInput(userOption,name);
  
    Console.WriteLine($"The Number you are selected {studentNumber}");

    
    if (studentNumber<=name.Length && studentNumber != 0)
    {
        int i = studentNumber - 1;
        string? selectedStudent = name[i];
        Console.WriteLine(selectedStudent);
        while (isValid)
        {
            Console.WriteLine("What would you like to know? Enter hometown/favorite food:");
            string? optionSelected = Console.ReadLine();
            if(optionSelected?.ToLower() == "hometown"|| optionSelected?.ToLower() == "home" || optionSelected?.ToLower() == "town")
            {
                string town = hometowns[i];
                Console.WriteLine($"{selectedStudent} is from {town}");
                
            }
            else if(optionSelected?.ToLower() == "favorite food" || optionSelected?.ToLower() == "food")
            {
                string food = favoriteFoods[i];
                Console.WriteLine($"{selectedStudent}'s favorite food is {food}");
                
            }
            else
            {
                Console.WriteLine("Invalid option");
                continue;
            }
            Console.WriteLine("Would you like to learn about another student? Enter y/n");
            string? nextStudent = Console.ReadLine();
            if(nextStudent.ToLower() == "n")
            {
                Console.WriteLine("Thank You");
                isValid = false;
                break;
            }
            else if(nextStudent.ToLower() == "y")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Option!");
                continue;
            }

        }
    }
    else
    {
        Console.WriteLine($"Invalid option please enter between 1-{name.Length}.");
    }
    
}
static int GetInput(string userOption, string[] name) {
  
    int studentNumber = 0;
    if (int.TryParse(userOption, out studentNumber))
    {
        return studentNumber;
    }
    else
    {
        if (userOption?.ToLower() == "student name")
        {
            Console.WriteLine("The List of students:");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{name[i]}");
            }
            Console.WriteLine("Please enter a name to check:");
            string? studentName = Console.ReadLine();
            for (int i =0;i< name.Length;i++)
            {
                if (name[i].Equals(studentName, StringComparison.OrdinalIgnoreCase))// String comparison
                {
                    return i + 1;
                }
            }
            
        }
        return studentNumber;

    }

}
