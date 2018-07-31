using System;
using L.P.Discography.Models;


namespace L.P.Discography.Data
{
    public class AlbumsRepository
    {
        public static Album[] _albums = new Album[]
        {
            new Album()
            {
                Id = 1,
                AlbumTitle = "Hybrid Theory",
                Released = "October 24, 2000",
                Label = "Warner Bros.",
                Formats = "CD, cassette, LP, digital download",
                Favorite = true,
                DescriptionHtml = "<p>Hybrid Theory is the debut studio album by American rock band Linkin Park, released on October 24, 2000, through Warner Bros. Records. As of 2017, the album has been certified diamond by the RIAA for sales in the band's home country of United States, with over eleven million units, peaking at number two on the US Billboard 200, and it also has reached high positions on other charts worldwide, with 30 million copies sold, making it the best-selling debut album since Guns N' Roses' Appetite for Destruction (1987) and the best-selling rock album of the 21st century.</p>",
                Songs = new Song[]
                {
                    new Song() { Title = "Papercut", Duration = "3.04"},
                    new Song() { Title = "One Step Closer", Duration = "2.35"},
                    new Song() { Title = "With You", Duration = "3.23"},
                    new Song() { Title = "Points of Authority", Duration = "3.20"},
                    new Song() { Title = "Crawling", Duration = "3.29"},
                    new Song() { Title = "Points of Authority", Duration = "3.20"},
                    new Song() { Title = "Runaway", Duration = "3.03"},
                    new Song() { Title = "By Myself", Duration = "3.09"},
                    new Song() { Title = "In the End", Duration = "3.36"},
                    new Song() { Title = "A Place for My Head", Duration = "3.04"},
                    new Song() { Title = "Cure for the Itch", Duration = "2.37"},
                    new Song() { Title = "Pushing Me Away", Duration = "3.11"}

                }

            },

            new Album()
            {
                Id = 2,
                AlbumTitle = "Meteora",
                Released = "March 25, 2003",
                Label = "Warner Bros., Machine Shop",
                Formats = "CD, cassette, LP, digital download",
                Favorite = true,
                DescriptionHtml = "<p>Meteora is the second studio album by American rock band Linkin Park. It was released on March 25, 2003 through Warner Bros. Records, following Reanimation, a collaboration album which featured remixes of songs included on their 2000 debut studio album Hybrid Theory. The album was produced by the band alongside Don Gilmore. The title Meteora is taken from the Greek Orthodox monasteries sharing the same name</p>",
                Songs = new Song[]
                {
                    new Song() { Title = "Foreword", Duration = "0.13"},
                    new Song() { Title = "Don't Stay", Duration = "3.07"},
                    new Song() { Title = "Somewhere I Belong", Duration = "3.33"},
                    new Song() { Title = "Lying from You", Duration = "2.25"},
                    new Song() { Title = "Hit the Floor", Duration = "2.44"},
                    new Song() { Title = "Easier to Run", Duration = "3.24"},
                    new Song() { Title = "Faint", Duration = "2.42"},
                    new Song() { Title = "Figure.09", Duration = "3.17"},
                    new Song() { Title = "Breaking the Habit", Duration = "3.16"},
                    new Song() { Title = "From the Inside", Duration = "2.55"},
                    new Song() { Title = "Nobody's Listening", Duration = "2.58"},
                    new Song() { Title = "Session", Duration = "2.24"},
                    new Song() { Title = "Numb", Duration = "3.07"}

                }

            },

            new Album()
            {
                Id = 3,
                AlbumTitle = "Minutes to Midnight",
                Released = "May 15, 2007",
                Label = "Warner Bros.",
                Formats = "CD, cassette, LP, digital download",
                Favorite = false,
                DescriptionHtml = "<p>Minutes to Midnight is the third studio album by American rock band Linkin Park, released on May 14, 2007, through Warner Bros. Records. The album was produced by Mike Shinoda and Rick Rubin. Minutes to Midnight was the band's follow-up album to Meteora (2003) and features a shift in the group's musical direction. For the band, the album marks a beginning of deviation from their signature nu metal sound. Minutes to Midnight takes its title from the Doomsday Clock.</p>",
                Songs = new Song[]
                {
                    new Song() { Title = "Wake", Duration = "1.40"},
                    new Song() { Title = "Given Up", Duration = "3.09"},
                    new Song() { Title = "Leave Out All the Rest", Duration = "3.29"},
                    new Song() { Title = "Bleed It Out", Duration = "2.44"},
                    new Song() { Title = "Shadow of the Day", Duration = "4.49"},
                    new Song() { Title = "What I've Done", Duration = "3.25"},
                    new Song() { Title = "Hands Held High", Duration = "3.53"},
                    new Song() { Title = "No More Sorrow", Duration = "3.41"},
                    new Song() { Title = "Valentine's Day", Duration = "3.16"},
                    new Song() { Title = "In Between", Duration = "3.16"},
                    new Song() { Title = "In Pieces", Duration = "3.38"},
                    new Song() { Title = "The Little Things Give You Away", Duration = "6.23"},

                }

            }

        };

        public Album[] GetAlbums()
        {
            return _albums;
        }

        public Album GetAlbum(int id)
        {
            Album albumToReturn = null;
            foreach (var album in _albums)
            {
                if (album.Id == id)
                {
                    albumToReturn = album;
                    break;
                }
            }
            return albumToReturn;
        }


    }
}
