using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Universal.Music.PlayerControlBoard
{
    class ControlBoard
    {
        static void LoadPluginInfo(Assembly asmPlugin)
        {
            Type ct = null;
            Type[] types = asmPlugin.GetTypes();
            foreach (Type t in types)
            {
                if (t.IsClass)
                {
                    Type i = t.GetInterface("Universal.Music.PlayerControlBoard.ControlIF");
                    if (i != null)
                    {
                        ct = t;
                        break;
                    }
                }
            }

            AuthorAttribute a = (AuthorAttribute)ct.GetCustomAttribute(typeof(AuthorAttribute));
            
            Console.WriteLine(ct.Name + " by " + a.DeveloperName);
        }
        static void RunPlugin(Assembly asmPlugin)
        {
            Type ct = null;
            Type[] types = asmPlugin.GetTypes();
            foreach (Type t in types)
            {
                if (t.IsClass)
                {
                    Type i = t.GetInterface("Universal.Music.PlayerControlBoard.ControlIF");
                    if (i != null)
                    {
                        ct = t;
                        break;
                    }
                }
            }
            ControlIF it = (ControlIF)Activator.CreateInstance(ct);

            it.PlayIt();
        }

        static void Main(string[] args)
        {
            /*
            Loading the 3rd Party assembly dynamically from the ControlBoard's Installation directory,
            where also the 3rd Party dlls go during installation process.
            */
            Assembly asmPlugin = Assembly.LoadFrom(@"D:\Do not touch\C# practice\CSharp_Practice\Classic Extendable application\3rdPartyBassSet\3rdPartyBassSet\bin\Debug\3rdPartyBassSet.dll");

            ControlBoard.LoadPluginInfo(asmPlugin);
            ControlBoard.RunPlugin(asmPlugin);

            Console.ReadKey();
        }
    }
}
