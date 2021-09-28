using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1.Entidades
{
    class ClsNotas
    {
        public double parcial_1;
        public double  parcial_2;
        public double parcial_3;
        public double laboratorio_1;
        public double laboratorio_2;
        public double laboratorio_3;
        public string nombre;
        public string apellido;
        public double promedio_final;
        private double periodo1;
        private double periodo2;
        private double periodo3;
        public double Parcial_1 { get => parcial_1; set => parcial_1 = value; }
        public double Parcial_2 { get => parcial_2; set => parcial_2 = value; }
        public double Parcial_3 { get => parcial_3; set => parcial_3 = value; }
        public double Laboratorio_1 { get => laboratorio_1; set => laboratorio_1 = value; }
        public double Laboratorio_2 { get => laboratorio_2; set => laboratorio_2 = value; }
        public double Laboratorio_3 { get => laboratorio_3; set => laboratorio_3 = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Promedio_final { get => promedio_final; set => promedio_final = value; }
        public double Periodo1 { get => periodo1; set => periodo1 = value; }
        public double Periodo2 { get => periodo2; set => periodo2 = value; }
        public double Periodo3 { get => periodo3; set => periodo3 = value; }
        public string Materia { get; internal set; }

        public ClsNotas()
        {  
         }

        public ClsNotas(double parcial_1, double parcial_2, double parcial_3, double laboratorio_1, double laboratorio_2, double laboratorio_3, string nombre, string apellido, double promedio_final, double periodo1, double periodo2, double periodo3)
        {
            this.parcial_1 = parcial_1;
            this.parcial_2 = parcial_2;
            this.parcial_3 = parcial_3;
            this.laboratorio_1 = laboratorio_1;
            this.laboratorio_2 = laboratorio_2;
            this.laboratorio_3 = laboratorio_3;
            this.nombre = nombre;
            this.apellido = apellido;
            this.promedio_final = promedio_final;
            this.periodo1 = periodo1;
            this.periodo2 = periodo2;
            this.periodo3 = periodo3;
        }
    }
    }
