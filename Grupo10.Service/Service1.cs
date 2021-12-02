using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Grupo10.Service
{
    public partial class Service1 : ServiceBase
    {
        /* 
            TODO: 
               * Analizar cada cuanto lanzar el servicio en base a cuando actualiza el BOE la info
               * Configuración del servicio (parametrización en bd):
                    - Flag
                    - Hora en concreto
                    - Reintentos
                    - Fecha a partir de la cual se quiere cargar información hasta hoy (si no esta informado el campo se cargará el día actual)
                * Conexión con el BOE. 
                * Transformación de pdf a fichero plano para tratar la información.
                * Conexión a la base de datos.
                * Detectar cambios.
                * Almacenar la información en el modelo de la base de datos.
                * Opcional: recibir alerta por correo electrónico     
      
          */
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {



        }

        protected override void OnStop()
        {


        }
    }
}
