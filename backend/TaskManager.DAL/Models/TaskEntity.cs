using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL.Models
{
    [Table("tasks")]
    public class TaskEntity
    {
        [Key]
        [Column("task_id")]
        public Guid TaskId { get; set; }
        [Column("title")]
        public string? Title { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Column("due_date")]
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        [ForeignKey("creator")]
        [Column("creator_id")]
        public Guid CreatorId { get; set; }
        public User? Creator { get; set; }
        [ForeignKey("assigned_user")]
        [Column("assigned_user_id")]
        public Guid AssignedUserId { get; set; }
        public User? AssignedUser { get; set; }
        [Column("comments")]
        public ICollection<Comment>? Comments { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
