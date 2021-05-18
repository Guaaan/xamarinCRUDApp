using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace xamarinApp.Models
{
    public class Productos
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int existencias { get; set; }
        public string precio { get; set; }
    }
}
