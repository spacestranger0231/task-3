using System;
using System.IO;

namespace hometask3
{
    class MENU
    {
        int i;
        public int menu()
        {
            Console.WriteLine("1. Output all:\n" +
                "2.Only 1 certain flat\n"
                + "3.The most guilty\n"
                + "4.No energy taken\n"
                + "5.EXIT\n");
            Console.WriteLine("Input what you want:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            return i;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MENU m = new MENU();
            int men;
            DateTime date = DateTime.Now;
            Console.WriteLine("\nThe current month is:\n");
            if (date.Month == 1)
                Console.WriteLine("January");
            else if (date.Month == 2)
                Console.WriteLine("February");
            else if (date.Month == 3)
                Console.WriteLine("March");
            else if (date.Month == 4)
                Console.WriteLine("April");
            else if (date.Month == 5)
                Console.WriteLine("May");
            else if (date.Month == 6)
                Console.WriteLine("June");
            else if (date.Month == 7)
                Console.WriteLine("July");
            else if (date.Month == 8)
                Console.WriteLine("August");
            else if (date.Month == 9)
                Console.WriteLine("September");
            else if (date.Month == 10)
                Console.WriteLine("October");
            else if (date.Month == 11)
                Console.WriteLine("November");
            else if (date.Month == 12)
                Console.WriteLine("December");
            Console.WriteLine("\n\n");

            int[] persh = new int[10];
            persh[1] = 18203;
            persh[2] = 24567;
            persh[3] = 23445;
            persh[4] = 12353;
            persh[5] = 23123;
            int[] ost = new int[10];
            ost[1] = 18350;
            ost[2] = 25000;
            ost[3] = 24330;
            ost[4] = 12353;
            ost[5] = 23250;

            double kvt = 1.68;
            string path = @"D:\\c#\\hometask3\\hometask3\\zapys.txt";
            StreamReader st = new StreamReader(path);

            string GetLine(int line)
            {
                {
                    for (int i = 0; i < line; i++)
                        st.ReadLine();
                    return st.ReadLine();
                }
            }

            do
            {
                men = m.menu();
                switch (men)
                {
                    case 1:
                        Console.WriteLine(st.ReadToEnd() + "\n");
                        break;
                    case 2:
                        Console.WriteLine("1.flat #23\n" + "2.flat #45\n" + "3.flat #3\n"
                            + "4. flat #12\n" + "5. flat #25\n" + "Input your choice:");
                        int line = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(GetLine(line));
                        Console.WriteLine("\n");
                        break;
                    case 3:
                        int max = 0;
                        int k = 1;
                        for (int i = 0; i < 5; i++)
                        {
                            int n = ost[i] - persh[i];
                            if (n >= max)
                            {
                                max = n;
                                k = persh[i];
                            }
                        }
                        double zab = max * kvt;
                        Console.WriteLine("The most guilty man: " + zab + "\n");
                       
                        string l = null;
                        
                        while ((l = st.ReadLine()) != null)
                        {
                            int i = 0;
                            if (l.Contains(k.ToString()))
                            {
                                Console.WriteLine(GetLine(i));
                            }
                            i++;
                        }
                        break;
                    case 4:
                        int g = 1;
                        for (int i = 0; i < 5; i++)
                        {
                            int j = ost[i] - persh[i];
                            if (j == 0)
                            { 
                               g = persh[i];
                            }
                        }
                       
                        Console.WriteLine("No energy man:\n");

                        string f = null;

                        while ((f = st.ReadLine()) != null)
                        {
                            int i = 0;
                            if (f.Contains(g.ToString()))
                            {
                                Console.WriteLine(GetLine(i));
                            }

                            i++;
                        }
                        break;
                    case 5:
                        break;
                }
            } while (men != 5);
        }
    }
}

//case 3 & 4 do not work properly:output the wrong person