Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "ася")
{
  Console.WriteLine("Ура, это же АСЯ!");  
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}