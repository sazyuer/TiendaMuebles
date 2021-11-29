/*MARTINEZ PEREZ, JOSE MANUEL
Practica Evaluable Tema 4
Ejercicio 1
Apartado 1.1 si 
Apartado 1.2 si 
Apartado 1.3 si 
Apartado 1.4 si 
Apartado 1.5 si
Apartado 1.6 si
Apartado 1.7 si
Apartado 1.8 si
Apartado 1.9 si
Apartado 1.10 si
 */
using System;
class PracT4Ej1
{
    struct ubicado
    {
        public byte pasillo;
        public byte seccion;
    }

    struct mueble
    {
        public string codigo;
        public string descripcion;
        public string marca;
        public float precio;
        public ubicado ubicacion;
    }


    static void Main()
    {
        const int MAX = 100;
        mueble[] muebles = new mueble[MAX];
        string opcion = "h";
        int cantidadMueble = 0;
        string codigoIntroducido = "1", respuesta = "1";

        //PRUEBAS
       /* cantidadMueble = 6;
        muebles[0].codigo = "123.456.78";
        muebles[1].codigo = "145.856.08";
        muebles[2].codigo = "023.357.18";
        muebles[3].codigo = "133.466.98";
        muebles[4].codigo = "233.456.18";
        muebles[5].codigo = "901.239.11";
        muebles[0].descripcion = "cama de matrimonio";
        muebles[1].descripcion = "sofa tres plazas";
        muebles[2].descripcion = "silla alta negra";
        muebles[3].descripcion = "armario marron";
        muebles[4].descripcion = "nido infantil";
        muebles[5].descripcion = "sillon rojo";
        muebles[0].precio = 369.95f;
        muebles[1].precio = 535.99f;
        muebles[2].precio = 39.45f;
        muebles[3].precio = 255.55f;
        muebles[4].precio = 639.45f;
        muebles[5].precio = 139.45f;
        muebles[0].ubicacion.pasillo = 2;
        muebles[1].ubicacion.pasillo = 2;
        muebles[2].ubicacion.pasillo = 23;
        muebles[3].ubicacion.pasillo = 17;
        muebles[4].ubicacion.pasillo = 17;
        muebles[5].ubicacion.pasillo = 17;
        muebles[0].ubicacion.seccion = 31;
        muebles[1].ubicacion.seccion = 14;
        muebles[2].ubicacion.seccion = 5;
        muebles[3].ubicacion.seccion = 32;
        muebles[4].ubicacion.seccion = 4;
        muebles[5].ubicacion.seccion = 12;*/

        //FIN PRUEBAS

        do
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Elige una opción:");
                Console.WriteLine();
                Console.WriteLine("1. Añadir un producto.");
                Console.WriteLine("2. Borrar un producto.");
                Console.WriteLine("3. Buscar un producto.");
                Console.WriteLine("4. Ordenar productos.");
                Console.WriteLine("5. Calcular importe.");
                Console.WriteLine("S. Salir.");
                Console.WriteLine("\nEscribe el número de la opción y " +
                    "pulsa \"INTRO\".");

                opcion = Console.ReadLine().ToUpper();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1": //Añadir productos
                        if (cantidadMueble < MAX)
                        {
                            Console.WriteLine
                                ("Introduce los datos que te soliciten, " +
                                "pulsa \"INTRO\" para  validar");

                            do
                            {
                                Console.WriteLine("\nIntroduce el código "
                                 + "del producto.");
                                codigoIntroducido = Console.ReadLine();
                                if (codigoIntroducido.Length == 10)
                                {
                                    muebles[cantidadMueble].codigo = codigoIntroducido;
                                }
                                else 
                                {
                                    Console.WriteLine("Error introduciendo " +
                                        "el número " + "de código. \nPor favor " +
                                        "vuelva a teclearlo," +
                                        "el formato es 111.222.33");
                                }

                            } while (codigoIntroducido.Length != 10);

                            bool respuestaCorrecta = false;
                            do
                            {
                                Console.WriteLine
                                    ("\nIntroduce la descripción del producto.");
                                respuesta = Console.ReadLine();
                                if (respuesta != "")
                                {
                                    muebles[cantidadMueble].descripcion = respuesta;
                                    respuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("Datos incorrectos, " +
                                        "vuelve a introducirlos.");
                                }
                            } while (!respuestaCorrecta);
                            do
                            { 
                                Console.WriteLine("\nIntroduce la marca " +
                                    "del producto.");
                                respuesta = Console.ReadLine().ToUpper();
                                if (respuesta != "")
                                {
                                    muebles[cantidadMueble].marca =
                                    respuesta;
                                    respuestaCorrecta = true;
                                }
                                else
                                {
                                    Console.WriteLine("Datos incorrectos, " +
                                        "vuelve a introducirlos.");
                                }
                            } while (!respuestaCorrecta);
                        
                            Console.WriteLine
                                ("\nIntroduce el precio del producto.");
                            muebles[cantidadMueble].precio =
                                Convert.ToSingle(Console.ReadLine());
                            do
                            {
                                Console.WriteLine
                                    ("\nIntroduce en el pasillo que se ubicará");
                                muebles[cantidadMueble].ubicacion.pasillo =
                                    Convert.ToByte(Console.ReadLine());
                            }
                            while (muebles[cantidadMueble].ubicacion.pasillo > 51);

                            do
                            {
                                Console.WriteLine
                                    ("\nIntroduce en la sección que se ubicará");
                                muebles[cantidadMueble].ubicacion.seccion =
                                Convert.ToByte(Console.ReadLine());
                            }
                            while (muebles[cantidadMueble].ubicacion.seccion
                            > 41);
                        }
                        else
                        {
                            Console.WriteLine("No se puede añadir mas productos");
                        }
                        cantidadMueble++;
                        break;

                    case "2"://Borrar producto
                       
                        if (cantidadMueble == 0)
                        {
                            Console.WriteLine("No hay productos para mostrar");
                        }
                        else
                        {
                            for (int i = 0; i < cantidadMueble; i++)
                            {
                                Console.WriteLine((i + 1) + ": " +
                                    muebles[i].codigo
                                    + " " + muebles[i].descripcion +
                                    " " + muebles[i].marca + " " +
                                    muebles[i].precio.ToString("#.##"));
                            }
                            string codigo;
                            do
                            {
                                Console.WriteLine("Introduzca el codigo del " +
                                    "producto.");
                                codigo = Console.ReadLine();

                                if (codigo.Length != 10)
                                {
                                    Console.WriteLine("Error introduciendo " +
                                        "el número " + "de código.\n Por favor " +
                                        "vuelva a teclearlo, " +
                                        "el formato debe ser como este  ejemplo" +
                                        " 111.222.33");
                                }
                                else
                                {
                                    bool localizado = false;
                                    for (int i = 0; i < cantidadMueble; i++)
                                    {
                                        //Console.WriteLine(muebles[i].codigo);
                                        //Console.WriteLine();

                                        if (muebles[i].codigo.Contains(codigo))
                                        {
                                            for (int j = i; j < cantidadMueble; j++)
                                            {
                                                muebles[j] = muebles[j + 1];
                                            }
                                            cantidadMueble--;
                                            localizado = true;
                                        }
                                    }
                                    if (!localizado)
                                    {
                                        Console.WriteLine("Codigo no encontrado");
                                    }
                                }
                            } while (codigo.Length != 10);

                        } 
                        break;

                    case "3"://Buscar productos
                        Console.WriteLine
                            ("Introduce parte de la descripción del " +
                            "producto a buscar");
                        string texto = Console.ReadLine();
                        bool encontrado = false;
                        for (int i = 0; i < cantidadMueble; i++)
                        {
                            if (muebles[i].descripcion.ToUpper()
                                .Contains(texto.ToUpper()))
                            {
                                Console.WriteLine((i + 1) + ":" +
                                    muebles[i].codigo + " " + 
                                    muebles[i].descripcion +
                                    " " + muebles[i].marca + " " +
                                    muebles[i].precio.ToString("0.00"));
                                encontrado = true;
                            }

                        }
                        if (!encontrado)
                        {
                            Console.WriteLine("\nNo se encontraron productos");
                        }
                        break;
                    case "4"://Ordenar productos
                       //Pruebas para ver los datos desordenados y
                       //comparar con los ordenados
                       
                        /* for (int i = 0; i < cantidadMueble; i++)// Muestro datos finales
                        {
                            Console.WriteLine("Sin ordenar: " + (i + 1) + ": " +
                                    muebles[i].codigo
                                    + " " + muebles[i].descripcion +
                                    " " + muebles[i].marca + " " +
                                    muebles[i].precio.ToString("#.##") +
                                " pasillo: {0}, seccion: {1} ", muebles[i]
                                .ubicacion.pasillo, muebles[i].ubicacion.seccion);
                        }
                        Console.WriteLine();*/

                        for (int i = 0; i < cantidadMueble -1; i++)
                        {
                            for (int j = i + 1; j < cantidadMueble; j++)
                            {
                                if (muebles[i].ubicacion.pasillo >
                                    muebles[j].ubicacion.pasillo || 
                                    muebles[i].ubicacion.pasillo ==
                                    muebles[j].ubicacion.pasillo && 
                                    (muebles[i].ubicacion.seccion > 
                                    muebles[j].ubicacion.seccion))
                                {
                                    mueble aux = muebles[i];
                                    muebles[i] =
                                    muebles[j];
                                    muebles[j] = aux;
                                    
                                }

                            }
                        }
                        for (int i = 0; i < cantidadMueble; i++)
                            //Muestro datos finales ordenados
                        {
                            Console.WriteLine("Ordenado: " + (i + 1) + ": " +
                                    muebles[i].codigo
                                    + " " + muebles[i].descripcion +
                                    " " + muebles[i].marca + " " +
                                    muebles[i].precio.ToString("#.##") +
                                " pasillo: {0}, seccion: {1} ",muebles[i]
                                .ubicacion.pasillo, muebles[i].ubicacion.seccion );
                        }

                        Console.WriteLine();
                        break;
                    
                    case "5"://Calcular importe
                        if (cantidadMueble == 0)
                        {
                            Console.WriteLine("No hay productos para sumar " +
                                "el precio. Elija otra opción.");
                        }
                        else
                        {
                            float suma = 0;
                            for (int i = 0; i < cantidadMueble; i++)
                            {
                                suma += muebles[i].precio;
                            }
                            Console.WriteLine("El importe total de todos los " +
                                "productos es: {0} ", suma.ToString("0.00"));
                        }
                        break;
                    
                    case "S":
                        Console.WriteLine("Fin del programa.");
                        break;
                    
                    default:
                        Console.WriteLine("Algo ha salido mal, " +
                            "intentaré arreglarlo");
                        break;

                }
            }
            catch (Exception errorEncontrado)
            {
                Console.WriteLine("Ha habido un error: {0}",
                errorEncontrado.Message);
            }
        }
        while (opcion != "S");
        Console.WriteLine("Gracias por usar el programa.");
    }
}
