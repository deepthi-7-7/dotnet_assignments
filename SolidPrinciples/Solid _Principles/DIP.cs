using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid__Principles
{
    internal class DIP
    {
        public interface ISwitchable
        {
            bool IsOn { get; }

            void TurnOn();
            void TurnOff();
        }


        public class LightSwitch
        {
            private ISwitchable device;

            public LightSwitch(ISwitchable device)
            {
                this.device = device;
            }

            public void Toggle()
            {
                if (device != null)
                {
                    if (device.IsOn)
                        device.TurnOff();
                    else
                        device.TurnOn();
                }
            }
        }

        public class Light : ISwitchable
        {
            public bool IsOn { get; private set; }

            public void TurnOn()
            {
                IsOn = true;
            }

            public void TurnOff()
            {
                IsOn = false;
            }
        }
    }
}
