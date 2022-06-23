using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Tickets.Any()) return; // If database has any ticket, the code below won't be executed.
            
            var activities = new List<Ticket>
            {
                new Ticket
                {
                    Status = "Resolved",
                    Priority = "Low",
                    Title = "Resolved Ticket 1",
                    Author = "Tony",
                    Type = "Task",
                    Description = "Ticket 2 months ago",
                    Project = "Minimalism",
                    EstimatedHours = 10,
                    AssignedDevs = "Stark",
                },
                new Ticket
                {
                    Status = "Resolved",
                    Priority = "Medium",
                    Title = "Resolved Ticket 2",
                    Author = "Bruce",
                    Type = "Story",
                    Description = "Ticket 2 months ago",
                    Project = "Check-out feature",
                    EstimatedHours = 5,
                    AssignedDevs = "Wayne",
                },
                new Ticket
                {
                    Status = "New",
                    Priority = "High",
                    Title = "New Ticket 1",
                    Author = "Steve",
                    Type = "Bug",
                    Description = "Program runs all day",
                    Project = "Stop the cap",
                    EstimatedHours = 66,
                    AssignedDevs = "Rogers",
                },
                new Ticket
                {
                    Status = "New",
                    Priority = "Low",
                    Title = "New Ticket 2",
                    Author = "Clark",
                    Type = "Task",
                    Description = "Popcorn needs popping",
                    Project = "Office snacks",
                    EstimatedHours = 1,
                    AssignedDevs = "Kent",
                },
                new Ticket
                {
                    Status = "Answered",
                    Priority = "Medium",
                    Title = "Answered Ticket 1",
                    Author = "Clint",
                    Type = "Bug",
                    Description = "Rodents running rampant",
                    Project = "Office snacks",
                    EstimatedHours = 3,
                    AssignedDevs = "Barton",
                },
                new Ticket
                {
                    Status = "Open",
                    Priority = "High",
                    Title = "Open Ticket 1",
                    Author = "Thor",
                    Type = "Task",
                    Description = "Loose nails",
                    Project = "Carpentry",
                    EstimatedHours = 2,
                    AssignedDevs = "Odinson",
                },
                new Ticket
                {
                    Status = "Postponed",
                    Priority = "Medium",
                    Title = "Postponed Ticket 1",
                    Author = "Bruce",
                    Type = "Story",
                    Description = "Thanos came",
                    Project = "Check-out feature",
                    EstimatedHours = 66,
                    AssignedDevs = "Banner",
                },
                new Ticket
                {
                    Status = "New",
                    Priority = "High",
                    Title = "New Ticket 3",
                    Author = "Pietro",
                    Type = "Bug",
                    Description = "Mercury poisoning",
                    Project = "Damage control",
                    EstimatedHours = 66,
                    AssignedDevs = "Maximoff",
                },
                new Ticket
                {
                    Status = "Resolved",
                    Priority = "Low",
                    Title = "Resolved Ticket 3",
                    Author = "Barry",
                    Type = "Task",
                    Description = "Food delivery",
                    Project = "Hot pizza",
                    EstimatedHours = 1,
                    AssignedDevs = "Allen",
                },
                new Ticket
                {
                    Status = "New",
                    Priority = "High",
                    Title = "New Ticket 4",
                    Author = "Michael",
                    Type = "Story",
                    Description = "Fix keyboard",
                    Project = "Space Jam",
                    EstimatedHours = 66,
                    AssignedDevs = "Jordan",
                },
            };

            await context.Tickets.AddRangeAsync(activities); // Not saving anything at this point.
            await context.SaveChangesAsync(); // Here's where the saving happens.
        }
    }
}