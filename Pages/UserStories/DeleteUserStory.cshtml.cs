using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationUserstories.Services;
using WebApplicationUserstories.Models;

namespace WebApplicationUserstories.Pages.UserStories
{
    public class DeleteUserStoryModel : PageModel
    {
        private UserStoryService userStoryService;


        //public int UserStoryIDToBeDeleted { get; set; }
        [BindProperty]
        public UserStory UserStory { get; set; }

        public DeleteUserStoryModel(UserStoryService userStoryService)
        {
            this.userStoryService = userStoryService;
        }

        public void OnGet(int id)
        {
            UserStory = userStoryService.GetUserStory(id);
            
        }

        public IActionResult OnPost()
        {
            UserStory deletedUserStory = userStoryService.DeleteUserStory(UserStory.Id);
            return RedirectToPage("UserStories");
        }



    }
}
