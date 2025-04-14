
using System;
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
public class Actividad4
{
    public static void Main(string[] args)
    {
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
    }

}
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