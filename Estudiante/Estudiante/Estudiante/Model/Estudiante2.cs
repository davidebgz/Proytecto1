using System;
using System.Collections.Generic;
using System.Text;

namespace Estudiante.Model
{
    public class Estudiante2 : CaseProperty
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _Apellido;

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }
        private string _Curso;

        public string Curso
        {
            get { return _Curso; }
            set { _Curso = value; }
        }
        private int _Edad;

        public int Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private string _Responsable;

        public string Responsable
        {
            get { return _Responsable; }
            set { _Responsable = value; }
        }

    }
}
