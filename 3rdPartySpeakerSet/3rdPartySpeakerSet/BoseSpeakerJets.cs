using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universal.Music.PlayerControlBoard;

namespace _3rdPartySpeakerSet
{
    [Author(DeveloperName = "Bose Inc.")]
    public class BoseSpeakerJets : ControlIF
    {
        public void PlayIt()
        {
            Console.WriteLine("Volume Up...Volume down...");
        }
        public void Firmware()
        {
            Console.WriteLine("Bose v5.1.0.3");
        }
    }
}
