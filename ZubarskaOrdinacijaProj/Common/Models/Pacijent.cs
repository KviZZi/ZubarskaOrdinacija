using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class Pacijent
    {
        private int id;
        private string mail;

        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}