using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagePack.Models
{
    [MessagePackObject]
    public class TodoItem
    {
        [Key(0)]
        public long Id { get; set; }
        [Key(1)]
        public string Name { get; set; }
        [Key(2)]
        public bool IsComplete { get; set; }
    }
}
