using LinqColeccion;

//Imprimir numeros pares

int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine("A continuacion te mostramos los numeros pares del arreglo");

//Sin Linq
//List<int> numerosPares = new List<int>();
//foreach (int numero in numeros)
//{
//    if(numero % 2 == 0)
//    {
//        numerosPares.Add(numero);
//    }
//}

//Con linq
//IEnumerable<int> numerosPares = from numero in numeros where numero % 2  == 0 select numero;

//Impresion numeros pares
//foreach (int numero in numerosPares)
//
 //   Console.WriteLine(numero);
 //}


ControlAlumnos controlAlumnos = new ControlAlumnos();
controlAlumnos.obtenerAlumnosPorCarrera(2);