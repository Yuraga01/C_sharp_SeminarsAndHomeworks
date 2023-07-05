Console.Write("Введите пятизначное число : ");
string text = Console.ReadLine();
char[] obrtext = text.ToCharArray();
Array.Reverse(obrtext);
string finaltext = new string (obrtext);
Console.WriteLine("Является ли число палиндромом?");
       if (text == finaltext)
       {
         Console.WriteLine("Да");
       }
       if (text != finaltext)
       {
         Console.WriteLine("Нет");
       }
     