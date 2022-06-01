using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace AppTcc.Model
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string username { get; set; }
    }
}
