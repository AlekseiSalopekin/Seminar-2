//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(100, 1000);

int num1 = num%100;
int num2 = num1/10;

Console.WriteLine(num);
Console.WriteLine(num2);


//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число ");
int num= Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num); 

if (numText.Length>2)
{
    Console.WriteLine(numText[2]);
}
else
{
    Console.WriteLine("cifri net");
}



// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите день недели:");
int num= Convert.ToInt32(Console.ReadLine());

if(num ==6 || num ==7)
{
    Console.WriteLine("Vihodnoi");
}
if(num<6)
{
    Console.WriteLine("Na rabotu");
} 