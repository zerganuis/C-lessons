﻿Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    global::System.Object value = Console.WriteLine("Вау, это же МАША!");
}
else 
{
    Console.Write("Привет ");
    Console.WriteLine(username);
    }
    