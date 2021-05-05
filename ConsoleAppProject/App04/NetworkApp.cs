using System;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        private int PostCount = 0;

        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("    Daniel's News Feed");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            String[] choices = new string[]
            {
                "Post Message", "Post Image", "" +
                "Display All Posts", "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DeleteMessage(); break;
                    case 5: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            Console.WriteLine("Enter file name: ");
            string filename = Console.ReadLine();
            Console.WriteLine("Enter caption: ");
            string caption = Console.ReadLine();
            PhotoPost post = new PhotoPost(news.GetAuthor(), filename, caption);
            news.AddPhotoPost(post);
        }

        private void PostMessage()
        {
            Console.WriteLine("Enter your message: ");
            PostCount++;
            string message = Console.ReadLine();
            MessagePost post = new MessagePost(news.GetAuthor(), message, PostCount);
            news.AddMessagePost(post);
        }

        private void DeleteMessage()
        {
            Console.WriteLine("Please enter the ID of the post you would like to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            news.RemovePost(id);
        }
    }
}
