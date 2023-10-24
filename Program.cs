    using System;

    namespace FlotaVehiculos
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Crear un objeto de la subclase Automovil
                Console.WriteLine("Información de la Flota de Vehículos:");
                Camion camion = new Camion("Volvo", "VNL", 2020, 5, 150000, 20000);
                camion.mostrarInformacion();
                MantenimientoVehiculo mantenimiento1 = new MantenimientoVehiculo(DateTime.Parse("2023-01-15"), "Cambio de aceite", 50000);
                MantenimientoVehiculo mantenimiento2 = new MantenimientoVehiculo(DateTime.Parse("2023-05-10"), "Revisión general", 120.0);
                camion.agregarMantenimiento(mantenimiento1);
                camion.agregarMantenimiento(mantenimiento2);
                foreach (var mantenimiento in camion.Mantenimiento)
                {
                    mantenimiento.mostrarInformación();
                }
                camion.calcularEficienciaCombustible();
                
            

    
            }
        }
    }

