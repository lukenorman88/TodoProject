using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace TodoProject.Models
{
    public class TodoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(125)]
        public string Name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateCreated { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        public DateTime? DateCompleted { get; set; }

        [Required]
        [ForeignKey("ToDoList")]
        public int ToDoListId { get; set; }

        //Navigation Property - Helps entity framework build db
        public virtual ToDoList ToDoList { get; set; }
    }
}
