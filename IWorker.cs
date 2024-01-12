using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdukosS.O.L.I.D_
{
    public interface IWorker
    {
        void Work();
        void Eat();
        void Sleep();
    }

    public class Worker : IWorker
    {
        public void Work()
        {
            // Performing work
        }

        public void Eat()
        {
            // Having lunch
        }

        public void Sleep()
        {
            // Sleeping
        }
    }

    public class Robot : IWorker
    {
        public void Work()
        {
            // Performing work
        }

        public void Eat()
        {
            // Robots don't eat, but forced to implement the method
            throw new NotImplementedException("Robots don't eat");
        }

        public void Sleep()
        {
            // Robots don't sleep, but forced to implement the method
            throw new NotImplementedException("Robots don't sleep");
        }
    }
}
