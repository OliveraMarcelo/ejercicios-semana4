
using System;

public class Actividad4
{
    public static void Main(string[] args)
    {
        //EJERCICIO 1
        Console.WriteLine("");
        Console.WriteLine("Ejercicio 1: ");
        //Console.WriteLine("Inicializar la clase Persona con solo el nombre");
        //Persona persona1 = new Persona();
        //persona1.mostrarDatos();
        Console.WriteLine("Inicializar la clase Persona con todos los atributos");
        Persona persona1 = new Persona("Marcelo Daniel", 22, 43814724);
        persona1.mostrarDatos();
        Console.WriteLine("Seteamos edad");
        persona1.setEdad(23);
        persona1.mostrarDatos();
        //EJERCICIO 2
        Console.WriteLine("");
        Console.WriteLine("Ejercicio 2: ");
        Calculadora calculadora = new Calculadora();
        Console.WriteLine("La suma de 2 + 3 es: " + calculadora.sumar(2, 3));
        Console.WriteLine("La suma de 2 + 3 + 4 es: " + calculadora.sumar(2, 3, 4));
        calculadora.sumar("La suma de 2 + 3 es: ", 2, 3);
        Console.WriteLine("EL numero 4 es par? " + calculadora.esPar(4));
        Console.WriteLine("EL numero 5 es par? " + calculadora.esPar(5));

    }

}

/* 
Ejercicio 1: 

Crear la clase Persona con diferentes constructores, para ello tendremos en cuenta las siguientes opciones: 

Inicializar una clase Persona con atributos nombre, edad y dni.
Crear un constructor sin parámetros que inicialice con valores por defecto.
Inicializar la clase Persona con solo el nombre.
Crear un constructor que reciba todos los atributos.
Crear un método mostrarDatos() que imprima los atributos.

Definir la edad como privado y crear un método de acceso (get) y un método para modificar su valor (set).
 */

public class Persona
{
    public string nombre;
    // Definir la edad como privado 

    private int edad;
    public int dni;
    //Crear constructor sin parametros que inicialice con valores por defecto

    /* public Persona()
    {
        nombre = "Marcelo";
        edad = 0;
        dni = 0;
    } */

    //Crear un constructor que reciba todos los atributos.
    public Persona(string nombre, int edad, int dni)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
    }
    //Crear un método de acceso (get) y un método para modificar su valor (set).
    public int getEdad()
    {
        return this.edad;
    }
    public void setEdad(int edad)
    {
        this.edad = edad;
    }
    public void mostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("DNI: " + dni);
    }
}
/* 
Ejercicio 2: 

Crear una clase Calculadora.

Crear un método sumar(int a, int b) que devuelva una suma.
Crear un método sumar(double a, double b, double c) para sumar tres números.
Crear un método sumar(string mensaje, int a, int b) que imprima el mensaje por consola y luego la suma.
Crear un método que devuelva true si un número es par o false si es impar bool esPar(int a).
 */
public class Calculadora
{
    public int sumar(int a, int b)
    {
        return a + b;
    }
    public int sumar(int a, int b, int c)
    {
        return a + b + c;
    }
    public void sumar(string mensaje, int a, int b)
    {
        Console.WriteLine(mensaje);
        Console.WriteLine(a + b);
    }
    public bool esPar(int a)
    {
        if (a % 2 == 0)
        {
            return true;
        }
        {
            return false;

        }
    }
}
