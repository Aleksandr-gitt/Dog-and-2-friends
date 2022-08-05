Console.WriteLine("Введите скорость первого друга ");
//string input1 = Console.ReadLine(); 
int FS1 = Convert.ToInt32(Console.ReadLine());  //Console.ReadLine() вместо input1

Console.WriteLine("Введите скорость второго друга ");
//string input2 = Console.ReadLine(); 
int FS2 = Convert.ToInt32(Console.ReadLine());  //Console.ReadLine() вместо input2

Console.WriteLine("Введите скорость собаки ");
//string input3 = Console.ReadLine(); 
int dogspeed = Convert.ToInt32(Console.ReadLine());   //Console.ReadLine() вместо input3

Console.WriteLine("Введите расстояние между друзьями ");
//string input4 = Console.ReadLine(); 
int distance = Convert.ToInt32(Console.ReadLine());   //Console.ReadLine() вместо input4

Console.WriteLine("К кому начинает бежать собака ");
//string input5 = Console.ReadLine(); 
int friend = Convert.ToInt32(Console.ReadLine());   //Console.ReadLine() вместо input5


int count = 0;
int time = 0;


while(distance > 10)
{
   if(friend == 1)
   {
   time = distance / (FS1 + dogspeed);
   friend = 2;
   }
   else
   {
   time = distance / (FS2 + dogspeed);
   friend = 1;
   }
   distance = distance - (FS1 +FS2) * time;
   count += 1;
}

Console.WriteLine("При скорости первого друга - " + FS1 + " и скорости второго равной " + FS2 + ", а также скорости собаки равной " + dogspeed);
Console.WriteLine("Собака пробежит от одного к другому " + count + " раз.");
