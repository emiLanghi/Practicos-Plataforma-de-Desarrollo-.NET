using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.DataAcces;
using TP2.Modelo;

namespace TP2
{
   

    class Class1
    {
        public static int submenu;
        public static int opcion;
        public static void Menu()
        {
            Console.WriteLine("Escoje una opción:");
            Console.WriteLine("[1] Proyecto");
            Console.WriteLine("[2] Factor");
            Console.WriteLine("[0] Salir");
            Console.Write("Opción: ");
        }
        
        public static void MenuProyecto()
        {
            Console.WriteLine("Elige accion a realizar:");
            Console.WriteLine("[1] Alta de Proyecto");
            Console.WriteLine("[2] Modificación de Proyecto");
            Console.WriteLine("[3] Baja de Proyecto");
            Console.Write("Opción: ");
        }
        public static void MenuFactor()
        {
            Console.WriteLine("Elige accion a realizar:");
            Console.WriteLine("[1] Alta de Factor");
            Console.WriteLine("[2] Modificación de Factor");
            Console.WriteLine("[3] Inhabilitacion de Factor");
            Console.Write("Opción: ");
        }

        private static void IngresarProyecto() {
                using (var contex = new TPContexto()) {
                var nombre = Console.ReadLine();
                var desc = Console.ReadLine();
                string fech = Console.ReadLine();
                DateTime dt = Convert.ToDateTime(fech);
                Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);
                var proyecto = new Proyecto { Nombre = nombre, Descripcion = desc, Fecha = dt };
                contex.Proyectos.Add(proyecto);
                contex.SaveChanges();

                var query = from p in contex.Proyectos
                            orderby p.Nombre
                            select p;

                Console.WriteLine("Todos los proyectos en la base de datos:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Nombre);
                }
            }
        }


        private static void ModificarProyecto() {
            using (var contex = new TPContexto()) {
                Proyecto mod = new Proyecto();
                
                var id = Console.ReadLine();
                int idf = Convert.ToInt32(id);
                mod.IdProyecto = idf;
                mod.Nombre = Console.ReadLine();
                mod.Descripcion = Console.ReadLine();
                var fec = Console.ReadLine();
                DateTime fech = Convert.ToDateTime(fec);
                mod.Fecha = fech;
                AdminProyect a = new AdminProyect();
                a.ActualizarProyecto(contex, mod);             

                }
            }


        private static void EliminarProyecto(){
            using (var contex = new TPContexto()){

                var id = Console.ReadLine();
                int idp = Convert.ToInt32(id);
                AdminProyect a = new AdminProyect();
                a.DeleteProyecto(contex, idp);
            }
        }



        private static void IngresarFactor()
        {
            using (var contex = new TPContexto())
            {
                var nombre = Console.ReadLine();
                var id = Console.ReadLine();
                int idf = Convert.ToInt16(id);
                var des = Console.ReadLine();
                var val = Console.ReadLine();
                int valor = Convert.ToInt16(val);

                var factor = new Factor { Nombre = nombre, IdFactor = idf };
                var valorizacion = new Valorizacion { Descripcion = des, Valor = valor };

                contex.Factores.Add(factor);
                contex.Valores.Add(valorizacion);
                contex.SaveChanges();

            }
        }

        


        private static void ModificarFactor(){

            using (var contex = new TPContexto())
            {
                Factor mod = new Factor();
                Valorizacion mod2 = new Valorizacion();
                var id = Console.ReadLine();
                int idf = Convert.ToInt32(id);
                mod.IdFactor = idf;
                mod.Nombre = Console.ReadLine();
                var va = Console.ReadLine();
                int val = Convert.ToInt32(va);
                mod2.Valor = val;
                mod2.Descripcion = Console.ReadLine();
                AdminFactor a = new AdminFactor();
                a.ActualizarFactor(contex, mod, mod2);
                     
        }
        }

            private static void EliminarFactor(){
            using (var contex = new TPContexto()){

                var id = Console.ReadLine();
                var idf = Convert.ToInt32(id);
                AdminFactor a = new AdminFactor();
                a.DeleteFactor(contex, idf);
            }
        }
    
        
        static void Main(string[] args){
       
            
            
            Menu();
            submenu = int.Parse(Console.ReadLine());
            switch (submenu)
            {
                case 1:
                    MenuProyecto();
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese ID, Nombre, Descripción y Fecha del Proyecto en dicho orden: ");
                            IngresarProyecto();
                            break;
                        case 2:
                            Console.WriteLine("Ingrese ID, Nombre, Descripcion, Fecha del proyecto para modificar: ");
                            ModificarProyecto();
                            break;
                        case 3:
                            Console.WriteLine("Ingrese ID del proyecto que desea eliminar: ");
                            EliminarProyecto();
                            break;
                    }
                    break;
                case 2:
                    MenuFactor();
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese ID, Nombre, Valor y Descripción del Factor: ");
                            IngresarFactor();
                            break;
                        case 2:
                            Console.WriteLine("Ingrese ID, Nombre, Valor y Descripcion del Factor para modificar");
                            ModificarFactor();
                            break;
                        case 3:
                            Console.WriteLine("Ingrese ID del Factor que desea Inhabilitar");
                            EliminarFactor();
                            break;

                    }
                    break;


            }
            Console.ReadKey();



        }
    }
}
        
