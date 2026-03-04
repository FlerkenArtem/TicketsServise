using System;
using System.Collections.Generic;
using System.Text;

namespace TicketsServise
{
    public class TicketsInfo
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public byte[] Pdf { get; set; }
        public TicketsInfo(string name, string place, byte[] pdf)
        {
            Name = name;
            Place = place;
            Pdf = pdf;
        }
        public override string ToString()
        {
            return $"{Name}: {Place}"; 
        }
    }
}
