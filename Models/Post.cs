using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakisApp.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int ThreadId { get; set; }


        public string PostText { get; set; }

        public DateTime TimeOfPostCreation { get; set; }

        public string NameOfPostCreator { get; set; }

        public bool MarkedAsAbusive { get; set; }
        public int TimesReported { get; set; }

    }
}
