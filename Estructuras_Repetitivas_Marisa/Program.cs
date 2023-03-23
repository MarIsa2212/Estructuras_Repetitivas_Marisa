namespace Estructuras_Repetitivas_Marisa
{
    internal class Ejercicios 
    {
        //METODO 1 
        public void Metodo1()
        {
            Console.WriteLine("Metodo 1");
            int num = 0; 
            do
            {
                Console.WriteLine("Ingrese un numero entero positivo: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " Es par");
                }
            } while (num != 99);
        }
        

        //Metodo 2 
        public void Metodo2()
        {
            Console.WriteLine("Metodo 2");
            Console.WriteLine("Ingrese un numero de lineas");
            int y = Convert.ToInt32(Console.ReadLine()); //numero de veces que se va a repetir el ciclo
            string fila = ""; //texto de la fila 

            for (int i = 1; i<=y; i++)
            {
                fila = fila + "" + i;
                Console.WriteLine(fila);
            }
        }

        //Metodo 3 
        public void Metodo3()
        {
            Console.WriteLine("Metodo 3");

            int suma = 0;

            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                    suma = suma + i;

                }
                else
                {

                }
            }
            Console.WriteLine(suma);
        }
        
        //Metodo 4 

        public void Metodo4()
        {
            Console.WriteLine("Metodo 4");
            Console.WriteLine("Ingrese un numero entero positivo");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {

                Console.Write(i + ": ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j) + "\t");
                }
                Console.Write("\n");
            }

        }
        static void Main(string[] args)
        {
            //Pruebas 
            Ejercicios p = new Ejercicios();
            p.Metodo1();
            p.Metodo2();
            p.Metodo3();
            p.Metodo4();
        }
    }
}