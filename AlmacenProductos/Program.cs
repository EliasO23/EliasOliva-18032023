// See https://aka.ms/new-console-template for more information
using AlmacenProductos.Models;

Console.WriteLine("\n---------------------------------------------------------");
Console.WriteLine("           BIENVENIDOS/AS A SU ALMACEN PREFERIDO         ");
Console.WriteLine("---------------------------------------------------------\n");

Console.WriteLine("  Registro de productos:");
Console.WriteLine("-------------------------------------");

AlmacenContext db = new AlmacenContext();

Producto producto = new Producto();

Console.WriteLine("- Nombre del producto: ");
producto.Nombre = Console.ReadLine();
Console.WriteLine("- Descripcion:");
producto.Descripcion = Console.ReadLine();
Console.WriteLine("- Precio: ");
producto.Precio = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("- Cantidad de productos existentes: ");
producto.Stock = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------------------\n");

db.Productos.Add(producto);
db.SaveChanges();


Console.WriteLine("  Productos registrados:");
Console.WriteLine("-----------------------------------------");
Console.WriteLine(" Id Cant. Producto Descripcion Precio ");
Console.WriteLine("-----------------------------------------");

var ListProductos = db.Productos.ToList();

    foreach (var prod in ListProductos){
    Console.WriteLine($"  {prod.Id}  {prod.Stock}    {prod.Nombre} / {prod.Descripcion} / ${prod.Precio}");

}

Console.WriteLine("\n---------------------------------------------------------");
Console.WriteLine("           ¡GRACIAS POR VISITAR NUESTRO ALMACEN!           ");
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine(" - Vueva pronto");
Console.WriteLine(" - Lo esperamos\n");
