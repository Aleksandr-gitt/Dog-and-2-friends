int FS1 = new Random().Next(1, 5);
int FS2 = new Random().Next(1, 5);
int Dogspeed = new Random().Next(1, 5);

int distance = 10000;
int count = 0;
int friend = 2;
int time = 0;

while(distance > 10)
{
   if(friend == 1)
   {
   time = distance / (FS1 + Dogspeed);
   friend = 2;
   }
   else
   {
   time = distance / (FS2 + Dogspeed);
   friend = 1;
   }
   distance = distance - (FS1 +FS2) * time;
   count += 1;
}

Console.WriteLine("При скорости первого друга - " + FS1 + " и скорости второго равной " + FS2 + ", а также скорости собаки равной " + Dogspeed);
Console.WriteLine("Собака пробежит " + count + "раз.");