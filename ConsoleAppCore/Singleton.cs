namespace ConsoleAppCore
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    //Cambio 1 en singleton rama PcPersonal para la rama PcPortatil
    class Singleton
    {
        private static Singleton instance;
        public string mensaje;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
            //set { instance = new Singleton(); }   
        }

        protected Singleton()
        {
            this.mensaje = "Hola mundo";
        }
    }
}
