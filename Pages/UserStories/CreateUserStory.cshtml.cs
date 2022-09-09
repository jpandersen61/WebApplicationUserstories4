using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplicationUserstories.Services;
using WebApplicationUserstories.Models;

namespace WebApplicationUserstories4.Pages.UserStories
{
    public class CreateUserStoryModel : PageModel
    {
        private static List<int> BVOptions = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private static List<string> PValues = new List<string>() { "meget vigtig", "vigtigt", "skal være med", "rart at have med" };
        private static List<int> SPoints = new List<int>() { 2, 3, 5, 8, 13, 21 };

        private UserStoryService _userStoryService;

        [BindProperty]
        public UserStory UserStory { get; set; }

        public List<int> BusinessValues { get { return BVOptions; } }

        [BindProperty]
        public List<int> AreChecked { get; set; }

        [BindProperty]
        public int InitialCheck { get; private set; }

        public List<string> PriorityValues { get { return PValues; } }


        [BindProperty]
        public string Priority { get; set; }

        public List<int> StoryPoints { get { return SPoints; } }

        [BindProperty]
        public int StoryPoint {get; set;}

        public CreateUserStoryModel(UserStoryService userStoryService)
        {

            _userStoryService = userStoryService;
        }
        public void OnGet()
        {
            InitialCheck = BVOptions[0];
            AreChecked = new List<int>();
            Priority = "meget vigtig";
            UserStory = new UserStory();
        }



        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            UserStory.BusinessValue = AreChecked.Max();

            switch (Priority)
            {
                case "meget vigtig":
                    UserStory.Priority = 1;
                    break;
                case "vigtigt":
                    UserStory.Priority = 2;
                    break;
                case "skal være med":
                    UserStory.Priority = 3;
                    break;
                case "rart at have med":
                    UserStory.Priority = 4;
                    break;
                default:
                    UserStory.Priority = 4;
                    break;
            }

            UserStory.StoryPoints = StoryPoint.ToString();

            _userStoryService.CreateUserStory(UserStory);

            return RedirectToPage("UserStories");
        }
    }
}
