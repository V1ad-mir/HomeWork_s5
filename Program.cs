// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2


// Console.WriteLine("Введите длинну массива");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] array = new int [num];

// int chislo=0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(100,1000);

//     if (array[i]%2==0)
//     {
//     chislo++;
//      Console.ForegroundColor = ConsoleColor.Yellow;
//      Console.Write(array[i]+" ");
//      Console.ResetColor();
//     }
//     else Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// Console.Write("Колличество четных чисел в масиве = "+chislo);


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int []inputAvto ()
// {
// Console.WriteLine("Введите первое число интервала");
// int numFist = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число интервала");
// int numLast = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длинну массива");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int[] array=new int [num3];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(numFist,numLast+1);  
// }
// return array;
// }
// int [] array=inputAvto();
// Console.WriteLine(String.Join(", ",array));
// int sum=0;
// for (int i = 1; i < array.Length; i=i+2)
// {
//   sum=sum+array[i];
//   }
//   Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = "+sum);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double []inputAvto (int num3,int num2,double[]array)
{
Console.WriteLine("Введите первое число интервала");
int numFist = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число интервала");
int numLast = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    array[i] =Math.Round( (new Random().Next(numFist, numLast+1)+(new Random().NextDouble())),num2);  
}
return array;
}

double []inputManual(int num3, double[]array)
{
for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine("Введите "+(1+i)+"й элемент масслива");
   array[i] = Convert.ToDouble(Console.ReadLine()); 
}
return array;
}

double []inputManualB()
{
    Console.WriteLine("Введите элементы массива через 'пробел' дробную часть через ','");
    double []array = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
    return array;
}

void output (double max, double min, double []array)
{
int priznak=0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i]==max) priznak=1;
  if (array[i]==min) priznak=2;
switch (priznak)
{
  case 1:
  {
     Console.ForegroundColor = ConsoleColor.Red;
     Console.Write(array[i]+" ");
     Console.ResetColor();
     priznak=0;
     break;
  }
  case 2: 
  {
     Console.ForegroundColor = ConsoleColor.Blue;
     Console.Write(array[i]+" ");
     Console.ResetColor();
     priznak=0;
     break;
  }
  default:
  {
  Console.Write( array[i]+" ");  
  break;
  }
  }
}
}

Console.WriteLine("Введите длинну массива");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колиичество цифр после запятой(от 0 до 7)");
int num2 = Convert.ToInt32(Console.ReadLine());

double [] array=new double [num3];
bool eror=true;
while (eror==true)
{
Console.WriteLine("Массив будет заданн в ручную(yes/no)");
string answer = Console.ReadLine();
switch (answer.ToLower())
  {
    case "yes":
    {
      bool eror2=true;
      while (eror2==true)
      {
      Console.WriteLine("Выберите способ ввода 1-Целиком(Длинна масссива введенная ранее не учитываеться) 2-По элементам");
      int sposob=Convert.ToInt32(Console.ReadLine());
         switch (sposob)
         {
         case 1: 
         {
         array=inputManualB();
         eror2=false;
         break;
         }
         case 2:
         {
         array=inputManual(num3, array);
         eror2=false;
         break;
         }
         default:
         {
         Console.WriteLine("Проверьте правильность ввода");
         eror2=true;
         break;
         }
         }
        
      }
     eror=false;
     break;
     }
    case "no":
    {

    array=inputAvto(num3,num2,array);
    eror=false;
    break;
    }
     default:
    {
    Console.WriteLine("Вы сами не знаете чего хотите ;-)");
    eror=true;
    break;
    }
    
  }
}
 double max=array[0];
  double min=array[0];
  for (int i = 1; i < array.Length; i++)
   {
  if (array[i]>max) max=array[i];
  else if (array[i]<min) min=array[i] ; 
 }

output (max, min, array);
Console.WriteLine( );
if (array.Length>1) 
{
  Console.WriteLine("Разница между максимальным и минимальным значением массива составляет : "+Math.Round((max-min),num2));
}
else Console.WriteLine("Раcчёт разницы не возможен, заданно одно число");
