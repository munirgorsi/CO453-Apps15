using System;
using System.Text;

namespace CO453_ConsoleAppAnswer.App04
{
    public class PhotoPost : Post
    {
        // the name of the image file
        public String Filename { get; set; }

        // a one line image caption
        public String Caption { get; set; }

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author,
            String filename, String caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }


        public override string GetSummary()
        {
            return base.GetSummary() + $" Photo: {Caption}";
        }

        /// <summary>
        /// Return as text the author's name, the time elapsed,
        /// the number of likes and how many comments the post has
        /// </summary>
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"\tPhoto Post");
            builder.AppendLine("\t----------");
            builder.AppendLine($"\tFilename: {Filename}");
            builder.AppendLine($"\tCaption: {Caption} \n");

            builder.Append(base.ToString());

            return builder.ToString();
        }


    }
}
