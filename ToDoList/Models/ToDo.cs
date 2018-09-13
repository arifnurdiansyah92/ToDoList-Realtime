using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public enum ToDoStatus
    {
        Dibuat = 0,
        Selesai = 1,
        Dibatalkan = 2
    }
    public class ToDo
    {
        public int ID { get; set; }
        public string Detail { get; set; }
        public DateTime Tanggal { get; set; }
        public ToDoStatus Status { get; set; }
        public int CreatedByID { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        public int AssignToID { get; set; }
        public ApplicationUser AssignTo { get; set; }
    }
    public class ToDoHistory
    {
        public int ID { get; set; }
        public ToDoStatus Status { get; set; }
        public DateTime Tanggal { get; set; }
        public int ToDoID { get; set; }
        public ToDo ToDo { get; set; }
        public int UserID { get; set; }
        public ApplicationUser User { get; set; }
    }
    public class ToDoKomen
    {
        public int ID { get; set; }
        public string Komentar { get; set; }
        public int ToDoID { get; set; }
        public ToDo ToDo { get; set; }
        public DateTime Tanggal { get; set; }
        public int UserID { get; set; }
        public ApplicationUser User { get; set; }
    }
}
