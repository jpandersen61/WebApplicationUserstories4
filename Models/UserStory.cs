

namespace WebApplicationUserstories.Models
{
    public class UserStory
    {
        private static int nextId=0;
        public int Id { get;  set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public int BusinessValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int Priority { get; set; }
        public string StoryPoints { get; set; }

        void NextID()
        {
            nextId++;
            Id = nextId;
        }

        public UserStory()
        {
            Id = 0;
            Title = "";
            Description = "";
            BusinessValue = 0;
            CreationDate = DateTime.Now;
            Priority = 0;
            StoryPoints = "None";
        }

        public UserStory(string title, string description, int businessValue, int priority, string storyPoints)
        {
            NextID();
            Title = title;
            Description = description;
            BusinessValue = businessValue;
            CreationDate = DateTime.Now;
            Priority = priority;
            StoryPoints = storyPoints;
        }


    }
}
