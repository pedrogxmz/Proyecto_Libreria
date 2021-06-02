using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Editorial
    {
        public int Id { get; }
        public string Description { get; }

        public Editorial(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }}
