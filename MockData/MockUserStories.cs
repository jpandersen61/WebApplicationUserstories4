using WebApplicationUserstories.Models;

namespace WebApplicationUserstories.MockData
{
    public class MockUserStories
    {
        private static List<UserStory> userStories = new List<UserStory>()
        {
            new UserStory("Create Story", "As P.O I want to create a new Story So ...",4,1,"Large"),
            new UserStory("Edit Story", "As P.O I want to edit a Story So ...",2,4,"Large"),
            new UserStory("Move Story", "As team member I want to move a Story So ...",3,2,"Medium"),
            new UserStory("Delete Story", "As team member I want to delete a Story So ...",2,5,"Large")
        };

        public static List<UserStory> GetMockUserStories()
        {
            return userStories;
        }
    }
}
