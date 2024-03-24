using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DAL.Models
{
    [Table("comments")]
    public class Comment
    {
        [Key]
        [Column("comment_id")]
        public Guid CommentId { get; set; }

        [Column("content")]
        public string? Content { get; set; }

        [ForeignKey("user_id")]
        public Guid UserId { get; set; }

        [Column("user")]
        public User? User { get; set; }

        [ForeignKey("task_id")]
        public Guid TaskId { get; set; }

        [Column("task")]
        public TaskEntity? Task { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
