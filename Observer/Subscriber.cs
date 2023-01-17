using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Subscriber : ISubscriber
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            Name = name;
        }
        public void Update(string context)
        {
            Console.WriteLine($"Hello {Name}! {context} is now available!");
        }
    }
}
