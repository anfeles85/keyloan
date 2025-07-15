using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyLoan.models
{
    internal class KeyRoom
    {
        private int id;
        private string name;
        private string room;
        private int count;
        private string observation;

        public KeyRoom() { }

        public KeyRoom(int id, string name, string room, int count, string observation)
        {
            this.Id = id;
            this.Name = name;
            this.Room = room;
            this.Count = count;
            this.Observation = observation;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Room { get => room; set => room = value; }
        public int Count { get => count; set => count = value; }
        public string Observation { get => observation; set => observation = value; }
    }
}
