using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Power_of_Thor
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Choose the position: X-lightPower Y-lightPower X-startingPosition Y-startingPosition");

            string[] inputs = Console.ReadLine().Split(' ');

            int lightX = int.Parse(inputs[0]); // the X position of the light of power
            int lightY = int.Parse(inputs[1]); // the Y position of the light of power

            int initialTX = int.Parse(inputs[2]); // Thor's starting X position
            int initialTY = int.Parse(inputs[3]); // Thor's starting Y position

            int thorX = initialTX;
            int thorY = initialTY;

            int count = 0;

            if (lightX >= 0 && lightX < 38
                  && lightY >= 0 && lightY < 17
                  && initialTX >= 0 && initialTX < 38
                  && initialTY >= 0 && initialTY < 38)
            {
                while (true)
                {
                    count++;
                    Console.WriteLine("Press enter for next direction");
                    Console.ReadLine();

                    string directionX = "";
                    string directionY = "";

                    if (thorX > lightX)
                    {
                        directionX = "W";
                        thorX--;
                    }
                    else if (thorX < lightX)
                    {
                        directionX = "E";
                        thorX++;
                    }

                    if (thorY > lightY)
                    {
                        directionY = "N";
                        thorY--;
                    }
                    else if (thorY < lightY)
                    {
                        directionY = "S";
                        thorY++;
                    }


                    if (directionX == "" && directionY == "") 
                    {
                        Console.WriteLine("You reach the light of power");
                    }
                    else
                    {
                        Console.WriteLine("Move " + count + " - " + "{0}{1}", directionY, directionX);
                    }
                }

            }
            else
            {
                while (true)
                {
                    Console.WriteLine("Youre out of map");
                    Console.ReadLine();
                }
            }
        }
    }
}
