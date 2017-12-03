using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Rectangle
    //asasaasasaas
{
    class rectangle
    {
            public int height, S, P, width;
            public int GetArea()
            {
                S = height * width;
                return S;
            }

            public int GetPerimeter()
            {
                P = 2 * (height + width);
                return P;
            }

            public void Draw()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
    }
}
//asdasdasdsasdadsdsdsad
