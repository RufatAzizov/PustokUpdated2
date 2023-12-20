using System.ComponentModel.DataAnnotations;

namespace PustokMVC.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }
        
        private DateTime? dateCreated = null;

        public int UpdatedAt { get; set; }
    }
}
