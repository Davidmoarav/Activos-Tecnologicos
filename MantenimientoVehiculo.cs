using System;

namespace FlotaVehiculos {
    class MantenimientoVehiculo{
        private DateTime fecha;
        private string descripcion;
        private double costo;

        public MantenimientoVehiculo(DateTime fecha, string descripcion, double costo){
            this.fecha = fecha;
            this.descripcion= descripcion;
            this.costo = costo;
        }
        public DateTime Fecha{
            get {return fecha;}
            set { fecha = value;}
        }
        public string Descripcion{
            get {return descripcion;}
            set { descripcion = value;}
        }
        public double Costo{
            get {return costo;}
            set { costo = value;}
        }
        public void mostrarInformación(){   
            Console.WriteLine("Mantenimientos:");
            Console.WriteLine($"Fecha: {Fecha}, Descripición: {Descripcion}, Costo: {Costo}");
          
        
        } 
    }
}