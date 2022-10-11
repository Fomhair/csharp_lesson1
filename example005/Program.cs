// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "олег") {
  Console.WriteLine("Привет, "+ username+ ", дружище!");
} else {
  Console.WriteLine("Привет, "+ username);
}