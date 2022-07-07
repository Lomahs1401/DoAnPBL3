using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;
using StringLengthAttribute = System.ComponentModel.DataAnnotations.StringLengthAttribute;

namespace DoAnPBL3.Models
{
    [Table("Ngon_Ngu")]
    public class Language
    {
        public Language()
        {
            Books = new HashSet<Book>();
        }

        public Language(int id_language, string nameLanguage)
        {
            ID_Language = id_language;
            NameLanguage = nameLanguage;
        }

        [Key]
        [Column("ID_NgonNgu")]
        [AutoIncrement]
        [Required]
        public int ID_Language { get; set; }

        [Column("tenNgonNgu")]
        [StringLength(255)]
        [Required]
        public string NameLanguage { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}