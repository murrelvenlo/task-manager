using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DAL.Models;

namespace TaskManager.DAL.Data
{
    public static class DBInitializer
    {
        public static async Task InitializeAsync(TaskManagerContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Add users
            var users = new List<User>();
            for (int i = 1; i <= 10; i++)
            {
                var user = new User
                {
                    UserId = Guid.NewGuid(),
                    FirstName = $"User{i}",
                    LastName = "Doe",
                    Email = $"user{i}@example.com",
                    Password = "password",
                    Phone = "123-456-7890"
                };
                users.Add(user);
            }
            context.Users.AddRange(users);

            // Add tasks
            var tasks = new List<TaskEntity>();
            for (int i = 1; i <= 10; i++)
            {
                var task = new TaskEntity
                {
                    TaskId = Guid.NewGuid(),
                    Title = $"Task {i}",
                    Description = $"Description for Task {i}",
                    DueDate = DateTime.UtcNow.AddDays(i),
                    Priority = Priority.Medium,
                    Status = Status.Pending,
                    CreatorId = users[i - 1].UserId, // Assign creator
                    AssignedUserId = users[(i + 1) % 10].UserId // Assign different user for assignment
                };
                tasks.Add(task);
            }
            context.Tasks.AddRange(tasks);

            // Add comments for each task
            var comments = new List<Comment>();
            for (int i = 0; i < tasks.Count; i++)
            {
                var comment = new Comment
                {
                    CommentId = Guid.NewGuid(),
                    Content = $"Comment for Task {i + 1}",
                    UserId = users[i].UserId, // Assign comment to the creator of the task
                    TaskId = tasks[i].TaskId
                };
                comments.Add(comment);
            }
            context.Comments.AddRange(comments);

            await context.SaveChangesAsync();
        }
    }

}
