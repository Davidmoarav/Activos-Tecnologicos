using System;

namespace FlotaVehiculos {

    // Clase derivada: Auto (hereda de vehiculo)
    class Motocicleta : Vehiculo {
        private int tipo;

        // Constructor especifico para Auto
        public Motocicleta(string marca, string modelo, int anioFabricacion, double consumo, double kilometraje, int tipo) : base(marca, modelo, anioFabricacion, consumo, kilometraje) {
            this.tipo = tipo;
        }


        public override void mostrarInformacion() {
            Console.WriteLine(
                $"Auto Marca: {Marca}, Modelo: {Modelo}, Año: {AnioFabricacion}, Consumo: {Consumo}, Kilometraje:{Kilometraje}, Tipo: {tipo}"
            );
        }  
        public override void calcularEficienciaCombustible(){
            double eficiencia = Kilometraje/Consumo;
            Console.WriteLine($"Cálculo de eficiencia de combustible para motocicleta: {eficiencia}");
        }
    }
}
