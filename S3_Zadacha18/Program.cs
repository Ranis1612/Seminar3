// **Задача 18:**
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Console.Clear();
// Console.Write("Введите число от 1 до 4: ");
// int a = int.Parse(Console.ReadLine()!);

// if(a == 1)                   //X>0&&Y>0
// {
// Console.WriteLine("X от 0 до + бесконечности; Y от 0 до + бесконечности ");
// }
// if(a == 2)                  // X<0&&Y>0
// {
// Console.WriteLine("X от 0 до - бесконечности; Y от 0 до + бесконечности");
// }
// if(a == 3)                  //X<0&&Y<0
// {
// Console.WriteLine("X от 0 до - бесконечности; Y от 0 до - бесконечности");
// }
// if(a == 4)                  // X>0&&Y<0
// {
// Console.WriteLine("X от 0 до + бесконечности; Y от 0 до - бесконечности");
// }
// if (a < 0 || a > 4){
//   Console.WriteLine("Число не корректно");
// };


// Вариант преподавателя
  //switch case
Console.Clear();
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine()!);

switch(quarter)
{
  case 1:
  {
    Console.Write("x > 0; y > 0 ");
    int x = 0, y = 0;
    break;
  }
   case 2:
  {
    Console.Write("x < 0; y > 0 ");
    break;
  }
   case 3:
  {
    Console.Write("x < 0; y < 0 ");
    break;
  }
     case 4:
  {
    Console.Write("x > 0; y < 0 ");
    break;
  }
default:
  {
    Console.Write("Введена неправильная четверть ");
    break;
  }
}