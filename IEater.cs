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
    }

    public interface IEater
    {
        void Eat();
    }

    public interface ISleeper
    {
        void Sleep();
    }

    public class Worker : IWorker, IEater, ISleeper
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
    }
}
