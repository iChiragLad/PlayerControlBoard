using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Music.PlayerControlBoard;

namespace _3rdPartyBassSet
{
    [Author(DeveloperName = "Beats Inc.")]
    public class BeatsBassBooster : ControlIF
    {
        public void PlayIt()
        {
            Console.WriteLine("Beats Beats Bass... Bass... Bum...");
        }
        public void Firmware()
        {
            Console.WriteLine("Beats v1.0.4.5");
        }
    }
}
