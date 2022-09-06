// See https://aka.ms/new-console-template for more information
using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;
using DataAccessLayer.Implementations;
using DataAccessLayer.Interfaces;
using Shared;

IDAL_Personas dalPersonas = new DAL_Personas_SQL();
IBL_Personas blPersonas = new BL_Personas(dalPersonas);

Console.WriteLine("Mi Primera APP...");

do
{
    try
    {
        Console.WriteLine("##### Nueva Persona #####");


        Persona persona = new Persona();
        Console.WriteLine("Nombre: ");
        persona.Nombre = Console.ReadLine();
        Console.WriteLine("Documento: ");
        persona.Documento = Console.ReadLine();

        blPersonas.AddPersona(persona);

        Console.WriteLine("Persona:");
        Console.WriteLine("     Nombre: " + persona.Nombre);
        Console.WriteLine("     Documento: " + persona.Documento);

    } catch (Exception ex) 
    {
        Console.WriteLine("ERROR: " + ex.Message);
    }
} while (!Console.ReadLine().Equals("exit"));



