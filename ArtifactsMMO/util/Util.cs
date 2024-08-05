using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtifactsMMO.Client.Schema;

namespace ArtifactsMMO
{
    static public class Util
    {
        public static void WaitForCooldown(Cooldown? cooldown)
        {
            if (cooldown == null) return;

            Console.WriteLine($"Waiting Until Cooldown: {cooldown.remainingSeconds}s");

            Thread.Sleep(cooldown.remainingSeconds * 1000);

        }

    }
}
