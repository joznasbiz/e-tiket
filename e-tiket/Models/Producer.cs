using System.ComponentModel.DataAnnotations;

namespace e_tiket.Models
{
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Realtionshpis
        public List<Movie> Movies { get; set; }
    }
}
