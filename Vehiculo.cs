using System;

namespace FlotaVehiculos{
    abstract class Vehiculo {   
        private string marca;
        private string modelo;
        private int anioFabricacion;
        private double consumo;
        private double kilometraje;
        private List<MantenimientoVehiculo> mantenimiento; 

        public Vehiculo(string marca, string modelo, int anioFabricacion, double consumo, double kilometraje ) {
            this.marca = marca;
            this.modelo = modelo;
            this.anioFabricacion = anioFabricacion;
            this.consumo = consumo;
            this.kilometraje = kilometraje;
            this.mantenimiento= new List<MantenimientoVehiculo>();
        }

        public string Marca {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo {
            get { return modelo; }
            set { modelo = value; }
        }
        public int AnioFabricacion {
            get { return anioFabricacion; }
            set { anioFabricacion = value; }
        }
        public double Consumo{
            get { return consumo;}
            set { consumo = value; }
        }
        public double Kilometraje{
            get { return kilometraje;}
            set { consumo = value; }
        }
        public List<MantenimientoVehiculo> Mantenimiento{
            get { return mantenimiento; }
            set { mantenimiento = value; }
        }
        public void agregarMantenimiento(MantenimientoVehiculo mantenimiento){
            this.mantenimiento.Add(mantenimiento);
        }
        public abstract void calcularEficienciaCombustible(); 
        public abstract void mostrarInformacion();
    }

}