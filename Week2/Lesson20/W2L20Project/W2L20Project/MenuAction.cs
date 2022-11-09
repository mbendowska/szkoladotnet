using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L20Project
{
    public class MenuAction
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string MenuName { get; set; }

        public MenuAction(int id)
        {
            Id = id;
        }

        public MenuAction(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
