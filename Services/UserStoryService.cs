using WebApplicationUserstories.Models;
using WebApplicationUserstories.MockData;


namespace WebApplicationUserstories.Services
{
    public class UserStoryService
    {
        private List<UserStory>? userStories;
        
        public UserStoryService()
        {
            userStories= MockUserStories.GetMockUserStories();
        }

        public List<UserStory> GetUserStories()
        {
            return userStories;
        }

        public UserStory GetUserStory(int id)
        {
            foreach (UserStory userStory in userStories)
            {
                if (userStory.Id == id)
                    return userStory;
            }
            return null;
        }

        public UserStory DeleteUserStory(int userstoryId)
        {
            UserStory userstoryToBeDeleted = null;
            foreach (UserStory us in userStories)
            {
                if (us.Id == userstoryId)
                {
                    userstoryToBeDeleted = us;
                    break;
                }
            }
            if (userstoryToBeDeleted != null)
            {
                userStories.Remove(userstoryToBeDeleted);
            }
            return userstoryToBeDeleted;
        }

    }



}
