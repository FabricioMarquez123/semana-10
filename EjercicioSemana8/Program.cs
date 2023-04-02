

using System;
using EjercicioSemana8.DAO;
using EjercicioSemana8.Models;

while (true)

{
    Console.WritelLine("Por Favor Seleccione una Opcidn del Menu");
    Console.WritelLine("1 - Guardar™");
    Console.WritelLine("2 - Listar™");
    Console.WritelLine("3 - Actualizar™");
    Console.WritelLine("4 - Eliminar");
    Console.WritelLine("5 - Salir");
    int op = int.Parse(Console.ReadlLine());
    Producto producto = new Producto();
    crudProductos crudProductos = new crudProductos();
    switch (op)
    {

        case 1:

            Console.WriteLine("Ingrese el Nombre del Producto que desee llevar");
            producto.Nombre = Console.ReadlLine();

            Console.WriteLine("Ingrese la Descripcidén Producto que desee llevar");
            producto.Descripcion = Console.ReadlLine();

            Console.WriteLine("Ingrese el Precio del Producto que desee llevar");
            producto.Precio = decimal.Parse(Console.ReadlLine());
            Console.WriteLine("Ingrese el Stock del Producto que desee llevar");
            producto.Stock = int.Parse(Console.ReadlLine());
            crudProductos.guardar(producto);

            break;
        case 2:

            var Lista = crudProductos.Listar();

            foreach (var item in Lista)

            {
                Console.WriteLine($"ID : {item.Id}");
                Console.WriteLine($"Nombre : {item.Nombre}");
                Console.WritelLine($"Descripcion : {item.Descripcion}");
                Console.WritelLine($"Precio : {item.Precio}");
                Console.WritelLine($"Stcok : {item.Stock} \n");

            }