using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakisApp.Models
{
    public class Thread
    {
        public int Id { get; set; }

        public string ThreadName { get; set; }
        public string NameOfThreadCreator { get; set; }

        public DateTime TimeOfThreadCreation { get; set; }
    }
}
