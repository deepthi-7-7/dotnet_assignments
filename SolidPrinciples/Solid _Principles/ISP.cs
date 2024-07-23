using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid__Principles
{
    internal class ISP
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
                // Working logic
            }

            public void Eat()
            {
                // Eating logic
            }

            public void Sleep()
            {
                // Sleeping logic
            }
        }

        public class Robot : IWorker
        {
            public void Work()
            {
                // Working logic
            }
        }

    }
    }
