using Work;
using System.Diagnostics;

Train[] speed = new Train[3];
Random rand = new Random();

for (int i = 0; i < speed.Length; i++)
{
    speed[i] = new Train(rand.Next(200), rand.Next(200), rand.Next(200));
    Console.WriteLine(speed[i]);
}