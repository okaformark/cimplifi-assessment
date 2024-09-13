using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimplifi_singleton
{
    public sealed class Singleton
    {
        private static volatile Singleton? instance;
        private static object syncRoot = new ();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("This illustrates a Singleton instance!");
        }
    }
}
