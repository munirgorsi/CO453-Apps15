using System;
using System.Text;

namespace CO453_ConsoleAppAnswer.App04
{
    public class MessagePost : Post
    {
        // an arbitrarily long, multi-line message
        public String Message { get; }


        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author,
            String text) : base(author)
        {
            Message = text;
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $" Message: {Message}";
        }

        /// <summary>
        /// Return as text the author's name, the time elapsed,
        /// the number of likes and how many comments the post has
        /// </summary>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"\tMessage Post");
            builder.AppendLine("\t----------");
            builder.AppendLine($"\tFilename: {Message}");

            builder.Append(base.ToString());

            return builder.ToString();
        }

    }
}