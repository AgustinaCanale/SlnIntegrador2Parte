using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlnIntegrador.Entidades;


namespace SlnIntegrador.Datos
{
    public class abmPaciente
    {
        private static DBClinicaIntegradorContext context = new DBClinicaIntegradorContext();

        public static int Insert(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return context.SaveChanges();
        }

        public static List<Paciente> SelectAll()
        {
            return context.Pacientes.ToList();
        }

        public static int Delete(Paciente paciente)
        {


            Paciente pacienteOrigen = context.Pacientes.Find(paciente.PacienteId);
            if (pacienteOrigen != null)
            {
                context.Pacientes.Remove(pacienteOrigen);

                return context.SaveChanges();
            }

            return 0;
        }

        public static int Update(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente.PacienteId);
            pacienteOrigen.Nombre = paciente.Nombre;
            pacienteOrigen.Apellido = paciente.Apellido;
            pacienteOrigen.Telefono = paciente.Telefono;
            pacienteOrigen.Email = paciente.Email;
            pacienteOrigen.Domicilio = paciente.Domicilio;
            pacienteOrigen.NroHistorialClinica = paciente.NroHistorialClinica;
            return context.SaveChanges();

        }

        public static Paciente SelectWhereById(int PacienteId)
        {
            return context.Pacientes.Find(PacienteId);

        }
    }
}
