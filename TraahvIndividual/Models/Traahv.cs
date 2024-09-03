using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace TraahvIndividual.Models
{
    [Table("Traahv")]
    public class Traahv
    {
        [Key]
        public int Id { get; set; }
        public string SoidukeNumber { get; set; }
        public string OmanikuNimi { get; set; }
        public string OmanikuEpost { get; set; }
        public DateTime Rikkumisekuupaev { get; set; }
        public int KiiruseUletamine { get; set; }

        public int TrahviSuurus { get; set; }
        public virtual ICollection<Login> Logins { get; set; }
    }
}