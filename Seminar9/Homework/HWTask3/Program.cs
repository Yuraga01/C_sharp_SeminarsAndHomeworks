/* Дана строка, содержащая только следующие символы:'(', ')', '{', '}', '[', ']'. 
Определите, является ли ваша строка допустимой. */


Console.WriteLine("Введите строку из символов (', ')', '{', '}', '[', ']'");
string text = Console.ReadLine();
int roundPar = 0;
int figurePar = 0;
int sqarePar = 0;
for (int i = 0; i < text.Length; i++)
{
    switch (text[i])
    {
        case '(':
        roundPar += 1;
        break;
        case '{':
        figurePar += 1;
        break;
        case '[':
        sqarePar += 1;
        break;
    }
}

for (int i = 0; i < text.Length; i++)
{
    switch (text[i])
    {
        case ')':
        roundPar -= 1;
        break;
        case '}':
        figurePar -= 1;
        break;
        case ']':
        sqarePar -= 1;
        break;
    }
}

if (roundPar == 0 && figurePar == 0 && sqarePar == 0) 
Console.WriteLine("Строка допустима");
else Console.WriteLine("Строка недопустима");
Console.ReadKey();