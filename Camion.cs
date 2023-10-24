using System;

namespace FlotaVehiculos {

    // Clase derivada: Auto (hereda de vehiculo)
    class Camion : Vehiculo {
        private int capacidadCarga;

        // Constructor especifico para Auto
        public Camion(string marca, string modelo, int anioFabricacion, double consumo, double kilometraje, int capacidadCarga) : base(marca, modelo, anioFabricacion, consumo, kilometraje) {
            this.capacidadCarga = capacidadCarga;
        }


        public override void mostrarInformacion() {
            Console.WriteLine(
                $"Auto Marca: {Marca}, Modelo: {Modelo}, Año: {AnioFabricacion}, Consumo: {Consumo}, Kilometraje:{Kilometraje}, Capacidad de carga: {capacidadCarga}"
            );
        }  
        public override void calcularEficienciaCombustible(){
            double eficiencia = Kilometraje/Consumo;
            Console.WriteLine($"Cálculo de eficiencia de combustible para automóvil: {eficiencia}");
        }
    }
}
