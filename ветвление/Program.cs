Console.Write("введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower( ) == "даша")
{
    Console.WriteLine("привет тётя ");
}
else
{
   Console.Write("привет:");
   Console.WriteLine(username); 
}