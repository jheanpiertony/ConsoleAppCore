namespace ConsoleAppCore
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
