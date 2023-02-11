// вариант преподавателя
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает что третьей цифры нет  645 - 5  78 - третьей цифры нет  32679 - 6

Console.Clear();
Console.Write("Введите число: ");
int a = Int32.Parse(Console.ReadLine()!);  //   Int32.Parse(Console.ReadLine() - считываем строку типа string и переводим его в число с выделением памяти 32
if(a < 100){                                      //   по сути Int32  int Parse  одно и то же
  Console.WriteLine("Число меньше 100 ");}
else{
  while(a > 1000){
    a /= 10; //    равносильно     a = a/10
  }
  Console.WriteLine(a%10);
}  


// int number = ReadInt("Введите число: ");   // проверить данный код
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));