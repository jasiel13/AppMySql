using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMySql.Shared.Modelos
{
    public class Tasks
    {
        [Key]
        public int Task_id { get; set; }
        public string Title { get; set; }
    }
}
