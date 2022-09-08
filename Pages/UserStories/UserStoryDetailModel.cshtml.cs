using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationUserstories.Services;
using WebApplicationUserstories.Models;



namespace WebApplicationUserstories3.Pages.UserStories
{
    public class UserStoryDetailModelModel : PageModel
    {
        [BindProperty]
        public UserStory UserStory { get; set; }
        private UserStoryService UserStoryService { get; set; }
        public List<UserStory> UserStories { get; private set; }

        public UserStoryDetailModelModel(UserStoryService userStoryService)
        {
            UserStoryService = userStoryService;
        }

        public void OnGet(int id)
        {
            UserStories = UserStoryService.GetUserStories();
            UserStory = UserStoryService.GetUserStory(id);
        }

    }
}
