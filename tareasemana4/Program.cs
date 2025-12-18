using System;
using System.Collections.Generic;

namespace AgendaClinica
{
    // ===== ESTRUCTURA =====
    struct Turno
    {
        public string Fecha;
        public string Hora;
        public Paciente Paciente;
        public Medico Medico;
    }

    // ===== CLASE PACIENTE =====
    class Paciente
    {
        public int Id;
        public string Nombre = "";
        public string Cedula = "";
        public string Telefono = "";

        public void Mostrar()
        {
            Console.WriteLine($"ID: {Id} | Nombre: {Nombre} | Cédula: {Cedula} | Teléfono: {Telefono}");
        }
    }

    // ===== CLASE MEDICO =====
    class Medico
    {
        public int Id;
        public string Nombre = "";
        public string Especialidad = "";

        public void Mostrar()
        {
            Console.WriteLine($"ID: {Id} | Nombre: {Nombre} | Especialidad: {Especialidad}");
        }
    }

    // ===== CLASE CLINICA =====
    class Clinica
    {
        public List<Paciente> Pacientes = new List<Paciente>();
        public List<Medico> Medicos = new List<Medico>();
        public Turno[,] Turnos = new Turno[5, 5];

        public void AgregarPaciente()
        {
            Paciente p = new Paciente();

            Console.Write("ID: ");
            int.TryParse(Console.ReadLine(), out p.Id);

            Console.Write("Nombre: ");
            p.Nombre = Console.ReadLine() ?? "";

            Console.Write("Cédula: ");
            p.Cedula = Console.ReadLine() ?? "";

            Console.Write("Teléfono: ");
            p.Telefono = Console.ReadLine() ?? "";

            Pacientes.Add(p);
            Console.WriteLine("Paciente registrado correctamente.\n");
        }

        public void AgregarMedico()
        {
            Medico m = new Medico();

            Console.Write("ID: ");
            int.TryParse(Console.ReadLine(), out m.Id);

            Console.Write("Nombre: ");
            m.Nombre = Console.ReadLine() ?? "";

            Console.Write("Especialidad: ");
            m.Especialidad = Console.ReadLine() ?? "";

            Medicos.Add(m);
            Console.WriteLine("Médico registrado correctamente.\n");
        }

        public void AsignarTurno()
        {
            Console.Write("Fila (0-4): ");
            int.TryParse(Console.ReadLine(), out int f);

            Console.Write("Columna (0-4): ");
            int.TryParse(Console.ReadLine(), out int c);

            if (f < 0 || f > 4 || c < 0 || c > 4)
            {
                Console.WriteLine("Posición fuera de rango.\n");
                return;
            }

            Turno t = new Turno();

            Console.Write("Fecha: ");
            t.Fecha = Console.ReadLine() ?? "";

            Console.Write("Hora: ");
            t.Hora = Console.ReadLine() ?? "";

            Console.WriteLine("Seleccione paciente:");
            for (int i = 0; i < Pacientes.Count; i++)
            {
                Console.Write($"{i}. ");
                Pacientes[i].Mostrar();
            }

            int.TryParse(Console.ReadLine(), out int ip);
            if (ip < 0 || ip >= Pacientes.Count)
            {
                Console.WriteLine("Paciente inválido.\n");
                return;
            }
            t.Paciente = Pacientes[ip];

            Console.WriteLine("Seleccione médico:");
            for (int i = 0; i < Medicos.Count; i++)
            {
                Console.Write($"{i}. ");
                Medicos[i].Mostrar();
            }

            int.TryParse(Console.ReadLine(), out int im);
            if (im < 0 || im >= Medicos.Count)
            {
                Console.WriteLine("Médico inválido.\n");
                return;
            }
            t.Medico = Medicos[im];

            Turnos[f, c] = t;
            Console.WriteLine("Turno asignado correctamente.\n");
        }

