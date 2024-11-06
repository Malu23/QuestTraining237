using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NoteTakingApp
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
