using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace axoftTareas
{
    public class Task
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public DateTime? Date { get; set; }
        public State State { get; set; }

    }
}
