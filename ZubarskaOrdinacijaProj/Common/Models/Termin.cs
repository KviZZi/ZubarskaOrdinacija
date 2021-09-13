using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    public class Termin
    {
        private int id;
        private string createdBy;
        private DateTime start;
        private DateTime end;
        private bool canceled;

        public int Id { get => id; set => id = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
        public bool Canceled { get => canceled; set => canceled = value; }
    }
}