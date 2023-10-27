using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2_
{
    public class Network : Computer, IConnectable
    {
        public void Connect()
        {

            Console.WriteLine("Select operation system:\n 1 - Windows 11\n 2 - Linux\n 3 - MacOs ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("Select PC:\n 1 - pc1\n 2 - pc2\n 3 - pc3\n 4 - pc4\n 5 - pc5 ");
                    int y = int.Parse(Console.ReadLine());
                    switch (y)
                    {
                        case 1:
                            Console.WriteLine($"Ur Pc: {pc1} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 2:
                            ChoiceOS = pc2;
                            Console.WriteLine($"Ur Pc: {pc2} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 3:
                            ChoiceOS = pc3;
                            Console.WriteLine($"Ur Pc: {pc3} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 4:
                            ChoiceOS = pc4;
                            Console.WriteLine($"Ur Pc: {pc4} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 5:
                            ChoiceOS = pc5;
                            Console.WriteLine($"Ur Pc: {pc5} - OS of ur PC: {ChoiceOS}");
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }

                    break;

                case 2:
                    Console.WriteLine("Select PC:\n 1 - pc1\n 2 - pc2\n 3 - pc3\n 4 - pc4\n 5 - pc5 ");
                    int ChoicePC1 = int.Parse(Console.ReadLine());
                    switch (ChoicePC1)
                    {
                        case 1:
                            ChoicePC = pc1;
                            Console.WriteLine($"Ur Pc: {pc1} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 2:
                            ChoicePC = pc2;
                            Console.WriteLine($"Ur Pc: {pc2} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 3:
                            ChoicePC = pc3;
                            Console.WriteLine($"Ur Pc: {pc3} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 4:
                            ChoicePC = pc4;
                            Console.WriteLine($"Ur Pc: {pc4} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 5:
                            ChoicePC = pc5;
                            Console.WriteLine($"Ur Pc: {pc5} - OS of ur PC: {ChoiceOS}");
                            break;
                    }

                    break;
                case 3:
                    Console.WriteLine("Select PC:\n 1 - pc1\n 2 - pc2\n 3 - pc3\n 4 - pc4\n 5 - pc5 ");
                    int ChoicePC2 = int.Parse(Console.ReadLine());
                    switch (ChoicePC2)
                    {
                        case 1:
                            ChoicePC = pc1;
                            Console.WriteLine($"Ur Pc: {pc1} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 2:
                            ChoicePC = pc2;
                            Console.WriteLine($"Ur Pc: {pc2} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 3:
                            ChoicePC = pc3;
                            Console.WriteLine($"Ur Pc: {pc3} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 4:
                            ChoicePC = pc4;
                            Console.WriteLine($"Ur Pc: {pc4} - OS of ur PC: {ChoiceOS}");
                            break;
                        case 5:
                            ChoicePC = pc5;
                            Console.WriteLine($"Ur Pc: {pc5} - OS of ur PC: {ChoiceOS}");
                            break;

                    }

                    break;
            }
        }
        void Share()
        {

        }
        void Receive()
        {

        }
    }
}

