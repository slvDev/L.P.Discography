using System;
namespace ComicBookGallery.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string AlbumTitle { get; set; }
        public string Released { get; set; }
        public string Label { get; set; }
        public string Formats { get; set; }
        public string DescriptionHtml { get; set; }
        public Song[] Songs { get; set; }
        public bool Favorite { get; set; }

        public string CoverImageFileName
        {
            get
            {
                return AlbumTitle.Replace(" ", "-").ToLower() + ".jpg";
            }
        }

    }
}