int count = 0;
int distance = 10000;
int FS1 = 1;
int FS2 = 2;
int Dogspeed = 5;
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

Console.WriteLine("Собака пробежит " + count + " раз.");