using System.ComponentModel.DataAnnotations;

namespace Futbolcular
{
    public class Footballer
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }
        public string Team { get; set; }
    }
}
