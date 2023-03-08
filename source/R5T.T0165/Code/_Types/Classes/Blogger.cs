using System;

using R5T.T0163;
using R5T.T0164;


namespace R5T.T0165
{
    /// <summary>
    /// Represents a person who writes blogs.
    /// </summary>
    public class Blogger
    {
        #region Static

        public static Blogger From(
            string fullName,
            string url)

        {
            var output = new Blogger
            {
                Name = new FullName(fullName),
                Url = new LinkHref(url),
            };

            return output;
        }

        #endregion


        public FullName Name { get; set; }
        public LinkHref Url { get; set; }
    }
}
