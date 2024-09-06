using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

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

      
        public void CalculateFine()
        {
            if (KiiruseUletamine <= 20)
            {
                TrahviSuurus = 50;
            }
            else if (KiiruseUletamine <= 40)
            {
                TrahviSuurus = 100;
            }
            else if (KiiruseUletamine <= 60)
            {
                TrahviSuurus = 200;
            }
            else
            {
                TrahviSuurus = 400;
            }
        }
    }
}
