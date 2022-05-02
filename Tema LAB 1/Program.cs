using System;

namespace Tema_LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Ex1();
           // Ex2();
           // Ex3();
           // Ex4();
           // Ex5();
           // Ex6();
           // Ex7();
           // Ex8();
           // Ex9();
           // Ex10();
        }
        static void Ex1()
        {
            /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
            paralelipiped dreptunghic, va afisa volumul lui*/
            Console.WriteLine("introduceti lungimea : ");
            int lungime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduceti latimea : ");
            int latime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduceti inaltimea : ");
            int inaltime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volumul paralelipipedului dreptunghic este : " + lungime * latime * inaltime + " cm3");
        }
        static void Ex2()
        {
            /*Scrieti un program care va calcula media aritmetica a trei numere citite de la tastatura*/
            Console.WriteLine("a =  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b =  ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("media aritmetica a celor trei numere este : " + (a + b + c) / 3);
        }
        static void Ex3()
        {
            /*Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la tastaura*/
            Console.WriteLine("Pintroduceti numarul de la tastatura : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int ultimaCifra = x % (10);
            Console.WriteLine("Ultima cifra a numarului " + x + " este " + ultimaCifra);
        }
        static void Ex4()
        {
            /*Scrieti un program care va afisa semnul unui numar citit de la tastatura*/
            Console.WriteLine("introduceti un numar intreg de la tastatura : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Numarul " + x + " este pozitiv");
            }
            else
            {
                if (x == 0)
                {
                    Console.WriteLine("Numarul " + x + " este zero");
                }
                else
                {
                    Console.WriteLine("Numarul " + x + " este negativ");
                }
            }
        }
        static void Ex5()
        {
            /*Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.*/
            Console.WriteLine("Introduceti primul numar : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar : ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(b + " " + a);

            }
            else
            {
                if (a == b)
                {
                    Console.WriteLine("cele doua numere sunt identice " + a + " " + b);
                }
                else
                {
                    Console.WriteLine(a + " " + b);
                }
            }
        }
        static void Ex6()
        {
            /*Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.*/
            Console.WriteLine("introduceti primul numar: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduceti primul numar: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduceti primul numar: ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("introduceti structura repetitiva ");
            }
        }
        static void Ex7()
        {
            /*Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar*/
            Console.WriteLine("Introduceti un numar de la tastatura : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x % 2;
            if (y == 0)
            {
                Console.WriteLine("numarul " + x + " este par");
            }
            else
            {
                Console.WriteLine("numarul " + x + " este impar");
            }
        }
        static void Ex8()
        {
            /*Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica daca x este divizibil cu y.*/
            Console.WriteLine("introduceti X : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduceti X : ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x % y == 0)
            {
                Console.WriteLine("X este divizibil cu Y");
            }
            else
            {
                Console.WriteLine("X nu este divizibil cu Y");
            }
        }
        static void Ex9()
        {
            /*screti un program care interschimba valorile a doua variabile intregi*/
            int a = 3;
            int b = 5;
            int aux = a;
            a = b;
            b = aux;
        }
        static void Ex10()
        {
            /*Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.*/
            int x = Convert.ToInt32(Console.ReadLine());
            int sumaCifrelor = x / 10 + x % 10;
            Console.WriteLine("suma cifrelor ale lui " + x + " este " + sumaCifrelor);
        }

    }
}
