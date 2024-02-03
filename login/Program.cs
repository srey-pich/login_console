Console.WriteLine("Login console !");
String name = "";
int pwd;

try
{
    Console.Write("Enter username =");
    name = Console.ReadLine();
    Console.Write("Enter Password =");
    pwd = Convert.ToInt32(Console.ReadLine());
    if (pwd == 0 )
    {
        Console.WriteLine("u success !!");
    }
    else
    {
        Console.WriteLine("you fail");
    }
}
catch(Exception e)
{
   // Console.WriteLine("Password must be interger number....");
    Console.WriteLine(e.Message);
}

