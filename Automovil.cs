using System;

namespace FlotaVehiculos {

    // Clase derivada: Auto (hereda de vehiculo)
    class Automovil : Vehiculo {
        private int cantidadPasajeros;

        // Constructor especifico para Auto
        public Automovil(string marca, string modelo, int anioFabricacion, double consumo, double kilometraje, int cantidadPasajeros) : base(marca, modelo, anioFabricacion, consumo, kilometraje) {
            this.cantidadPasajeros = cantidadPasajeros;
        }


        public override void mostrarInformacion() {
            Console.WriteLine(
                $"Auto Marca: {Marca}, Modelo: {Modelo}, Año: {AnioFabricacion}, Consumo: {Consumo}, Kilometraje:{Kilometraje}, Pasajeros: {cantidadPasajeros}"
            );
        }  
        public override void calcularEficienciaCombustible(){
            double eficiencia = Kilometraje/Consumo;
            Console.WriteLine($"Cálculo de eficiencia de combustible para automóvil: {eficiencia}");
        }
    }
}
