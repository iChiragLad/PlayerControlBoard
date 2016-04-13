using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universal.Music.PlayerControlBoard
{
    public interface ControlIF
    {
        void PlayIt();
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class AuthorAttribute : System.Attribute
    {
        public string DeveloperName { get; set; }
    }
}
