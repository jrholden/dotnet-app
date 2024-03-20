
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context){
            if (context.Activities.Any()) return;

            var activities = new List<Activity>{
                new Activity {
                    Title = "ACT 1",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Sample Desc1",
                    Category = "drinks",
                    City = "London",
                    Venue = "Disco"
                },
                new Activity {
                    Title = "ACT 2",
                    Date = DateTime.UtcNow.AddMonths(-2),
                    Description = "Sample Desc2",
                    Category = "jokes",
                    City = "Toronto",
                    Venue = "Pub"
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}