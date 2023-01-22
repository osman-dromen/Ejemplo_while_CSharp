internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejemplo 1 de bucle WHILE");

        Console.WriteLine("Deseas entrar en el bucle WHILE");

        string respuesta = Console.ReadLine();

        while(respuesta != "no")
        {
            Console.WriteLine("Estas dentro del bucle WHILE");

            Console.WriteLine("Introduce tu nombre, porfavor");
            string nombre = Console.ReadLine();

            Console.WriteLine($"{nombre} saldras del bucle WHILE cuando respondas 'no'");

            Console.WriteLine("¿Deseas repetir otra vez?");
            respuesta = Console.ReadLine();

            if (respuesta == "no")
            {
                Console.WriteLine("Has salido del bucle WHILE");
            }
        }

        Console.WriteLine("Práctica del 1 al 100 ejemplo 2 de bucle while");
        Random num = new Random();
        //Variable que guardara la respuesta si desea jugar otra partida e iniciada en si
        string otraVez = "si";

        while (otraVez == "si")
        {
            //Numero aleatorio entre 0 y 100
            int numAleatorio = num.Next(0, 100);
            //Variable que guardar el numero del readline
            int resp = 101;
            //Variable intentos realizados
            int i = 0;

            Console.WriteLine("--------Adivine el número de entre 0 y 100--------");

            while (resp != numAleatorio)
            {
                Console.WriteLine($"\n>>>>>Ingrese un número (intento {i+1}):");
                i++;
                resp = Int32.Parse(Console.ReadLine());

                //Aqui le doy pistas al usuario sobre el número que desea adivinar
                if (resp > numAleatorio)
                {
                    Console.WriteLine("------PISTA: menos------");

                }else if(resp<numAleatorio)
                {
                    Console.WriteLine("------PISTA: más------");

                }
                //Al adivinar el numero le pregunto a usuario si desea jugar otra partida
                else if (resp == numAleatorio)
                {
                    Console.WriteLine($"\n****-----CONGRATULATIONS Adivinaste el número {numAleatorio} en {i} intentos-----****");
                    Console.WriteLine(">>>Deseas realizar otra pártida (si/no)");
                    otraVez = Console.ReadLine();
                }
            }
        }
        

        
        Console.WriteLine("Ha términado el programa");
    }
}