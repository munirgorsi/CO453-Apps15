using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// This class will be the uer interface which allowd
    /// users to post messages and photos
    /// </summary>
    public class PostsUI
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// This code defines a method called "DisplayMenu" that,
        /// in a loop that lasts until the user chooses to end it,
        /// shows a menu and asks the user to choose an option.
        /// </summary>

        public void DisplayMenue()
        {
            ConsoleHelper.OutputHeading("App04: My Social Network by Muhammad Munir");

            string[] choices = new string[]
             {
                 "Add Message", "Add Photo Post",
                "Remove Post", "Add Comment" ,
                "Display All Post", "Like Post",
                "Display By Author" , "Unlike Post", "Quit"
            };

            bool quit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: AddMesage(); break;
                    case 2: AddPhoto(); break;
                    case 3: RemovePost(); break;
                    case 4: AddComment(); break;
                    case 5: DisplayAllPosts(); break;
                    case 6: LikePosts(); break;
                    case 7: DisplayByAuthor(); break;
                    case 8: UnlikePost(); break;
                    case 9: quit = true; break;

                }
            } while (!quit);
        }
        private void DisplayAllPosts()
        {
            news.Display();
        }

        /// <summary>
        ///The user's input is used to update the post with the message.
        /// </summary>
        private void AddMesage()
        {
            ConsoleHelper.OutputTitle("Message Post");
            string name = GetUserName();
            Console.WriteLine("Please Enter your Message > ");
            string message = Console.ReadLine();
            MessagePost post = new MessagePost(name, message);
            news.AddMessagePost(post);
            ConsoleHelper.OutputTitle("You have just posted this message:");
            Console.WriteLine();
            post.Display();
        }

        private void AddPhoto()
        {
            ConsoleHelper.OutputTitle("Add Photo/Image");
            string Author = GetUserName();

            Console.WriteLine("Please enter your Image Filename> ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your image caption >");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(Author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image:");

            post.Display();
        }
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle("Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(
                " Please enter the post id >", 1, news.GetNumberOfPosts());
            news.RemovePost(id);
        }
        /// <summary>
        ///By asking the user for a post id, this method deletes the associated post from the 'news' object.
        /// </summary>
        private void AddComment()
        {
            ConsoleHelper.OutputTitle("Adding a Comment");

            int id = (int)ConsoleHelper.InputNumber(
                "Please enter the post id >", 1, news.GetNumberOfPosts());

            Post post = news.FindPost(id);

            Console.Write("Please enter your name >");
            string author = Console.ReadLine();

            Console.Write("Please enter your comment >");
            string comment = Console.ReadLine();

            post.AddComment(comment, author);

            ConsoleHelper.OutputTitle("You have just added this comment:");

            post.Display();

        }
        ///<summary>
        ///this method ask user to comment on selected post
        ///</summary
       
        private void LikePosts()
        {
            ConsoleHelper.OutputTitle("Like Post");

            int id = (int)ConsoleHelper.InputNumber(
                "Please enter the post id >", 1, news.GetNumberOfPosts());

            Post post = news.FindPost(id);

            post.Like();

            ConsoleHelper.OutputTitle("You have just liked this post:");

            post.Display();
        }
        /// <summary>
        ///The liked post is shown and a way for like a post in a news system is defined by this code.
        ///The Like() function of the associated post object is then called after the user is prompted to enter the post id.
        /// </summary>
        private void UnlikePost()
        {
            ConsoleHelper.OutputTitle("Disliking a Post");

            int id = (int)ConsoleHelper.InputNumber(
                "Please enter the post id >");

            Post post = news.FindPost(id);
            if (post != null)
            {
                post.Unlike();

                ConsoleHelper.OutputTitle("You have just Disliked this post:");

                post.Display();
            }
            else Console.WriteLine("ID not found");

           
        }

        /// <summary>
        ///This method demonstrates articles written by a single author.
        ///The DisplayByAuthor function of the news object is called,
        ///and the user is prompted for the author's name.
        /// </summary>
        private void DisplayByAuthor()
        {
            ConsoleHelper.OutputTitle("Displaying Posts by Author");

            string author = GetUserName();
            news.DisplayByAuthor(author);
        }

        /// <summary>
        ///The user is prompted to submit their name using this method,
        ///which then returns the input as a string.
        /// </summary>
        private string GetUserName()
        {
            Console.Write("Please Enter Your Name >");
            string name = Console.ReadLine();

            return name;
        }
    }
}
