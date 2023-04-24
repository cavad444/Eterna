using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public string Desc { get; set; }
        public string Icon { get; set; }
    }
}
