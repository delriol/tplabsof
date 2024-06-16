using TrabajoPracticoIntegrador.Aplicacion;
using TrabajoPracticoIntegrador.Aplicacion.dto;
using TrabajoPracticoIntegrador.Dominio.Entidades;
using TrabajoPracticoIntegrador.Infraestructura;

Console.WriteLine("---+++MYSQL+++--- \n");
new ListVehiculoServiceApplication(new VehiculoRepositorioInMySqlServer()).Execute().ForEach(vehiculo =>
{
    Console.WriteLine("ID: " + vehiculo.getId());
    Console.WriteLine("Marca: " + vehiculo.getMarca());
    Console.WriteLine("Modelo: " + vehiculo.getModelo());
    Console.WriteLine("Motor: " + vehiculo.getMotor());
    Console.WriteLine("Chasis: " + vehiculo.getChasis());
    Console.WriteLine("\n");
});

Console.WriteLine(" \n---+++PostgreSQL+++--- \n");
new ListVehiculoServiceApplication(new VehiculoRepositorioInPostgreSQL()).Execute().ForEach(vehiculo =>
{
    Console.WriteLine("ID: " + vehiculo.getId());
    Console.WriteLine("Marca: " + vehiculo.getMarca());
    Console.WriteLine("Modelo: " + vehiculo.getModelo());
    Console.WriteLine("Motor: " + vehiculo.getMotor());
    Console.WriteLine("Chasis: " + vehiculo.getChasis());
    Console.WriteLine("\n");
});


Console.WriteLine(" \n---+++ Save In PostgreSQL+++--- \n");
new SaveVehiculoServiceApplication(new VehiculoRepositorioInPostgreSQL()).Execute(new VehiculoDto(
    Guid.NewGuid(),
    "Renault",
    "Sandero",
    "1.6 Nafta",
    "12ASDASD123"));

/*
Console.WriteLine(" \n---+++ Update In PostgreSQL+++--- \n");
new UpdateVehiculoServiceApplication(new VehiculoRepositorioInPostgreSQL()).Execute(new VehiculoDto(
    Guid.Parse("d3f29f6d-8b69-4c5f-9fb2-3f276dc5fbf9"),
    "Volskwagen",
    "Gol",
    "1.0 Nafta",
    "12ASDASD123"));


*/

Console.WriteLine(" \n---+++Delete In PostgreSQL+++--- \n");
new ListVehiculoServiceApplication(new VehiculoRepositorioInPostgreSQL()).Execute().ForEach(vehiculo =>
{
    Console.WriteLine("ID: " + vehiculo.getId());
    Console.WriteLine("Marca: " + vehiculo.getMarca());
    Console.WriteLine("Modelo: " + vehiculo.getModelo());
    Console.WriteLine("Motor: " + vehiculo.getMotor());
    Console.WriteLine("Chasis: " + vehiculo.getChasis());
    Console.WriteLine("\n");
});



