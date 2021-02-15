﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lexico1
{
    class Token
    {
        public enum clasificaciones
        {
            identificador, numero, asignacion, inicializacion,
            finSentencia, operadorLogico, operadorRelacional,
            operadorTermino, operadorFactor, incrementoTermino, 
            incrementoFactor, cadena, operadorTernario, caracter
        }
        private string contenido;
        private clasificaciones clasificacion;

        public void setContenido(string contenido)
        {
            this.contenido = contenido;
        }

        public void setClasificacion(clasificaciones clasificacion)
        {
            this.clasificacion = clasificacion;
        }

        public string getContenido()
        {
            return contenido;
        }

        public clasificaciones getClasificacion()
        {
            return clasificacion;
        }
    }
}
