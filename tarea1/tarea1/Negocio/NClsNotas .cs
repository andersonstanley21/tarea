using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea1.Entidades;

namespace tarea1.Negocio
{
    class NClsNotas
    {
        public string CalculoDeNotas(ClsNotas datos) 
        {
            datos.Periodo1 = datos.laboratorio_1 * 0.40 + datos.parcial_1 * 0.60;
            datos. Periodo2 = datos.laboratorio_2 * 0.40 + datos.parcial_2 * 0.60;
            datos.Periodo3 = datos.laboratorio_3* 0.40 + datos.parcial_3 * 0.60;
             datos.Promedio_final = (datos.Periodo1 + datos.Periodo1 + datos.Periodo1) / 3;
            datos.Promedio_final = Convert.ToDouble(datos.Promedio_final);

             
                return "\nperiodo : " + datos.Periodo1 + "\nperiodo2 : " + datos.Periodo2 + "\nperiodo3 : " + datos.Periodo3;



                















        }
            

            
         
            


    }
}
