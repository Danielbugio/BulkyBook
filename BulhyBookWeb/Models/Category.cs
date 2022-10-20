using System.ComponentModel.DataAnnotations;

namespace BulhyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }

        // Ao igualar a propriedade em dateTime.Now faz com que sempre que se instancie um objeto desta classe este valor fica preenchida com a data atual
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
