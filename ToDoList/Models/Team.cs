using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Nama { get; set; }
        public string Deskripsi { get; set; }
        public ICollection<Anggota> Anggota { get; set; }
    }
    public class Anggota
    {
        public int ID { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public int UserID { get; set; }
        public ApplicationUser User { get; set; }
    }
}
