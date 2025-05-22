using DocumentaryBlazorApp.Models;
using Microsoft.EntityFrameworkCore;


namespace DocumentaryBlazorApp.Data
{
    public static class SampleData
    {
        public static void AddSampleRecords(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Documentary>().HasData(
               new Documentary
               {
                   Id = 1,
                   Title = "Planet Earth",
                   Director = "Alastair Fothergill",
                   Category = "Nature",
                   Description = "A BBC nature documentary series exploring Earth's diverse environments and wildlife.",
                   Language = Language.English,
                   Duration = 550,
                   Year = 2006,
                   ImageUrl = "/images/planetEarth.jpg",
                   TrailerUrl = "https://www.youtube.com/watch?v=I8Az_IIgw4U",
                   Review = "A breathtaking visual journey through Earth's most remote locations. The cinematography and narration are unforgettable."
               });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 2,
                    Title = "The Social Dilemma",
                    Director = "Jeff Orlowski",
                    Category = "Technology",
                    Description = "Former tech insiders reveal how social media is reprogramming civilization.",
                    Language = Language.English,
                    Duration = 94,
                    Year = 2020,
                    ImageUrl = "/images/theSocialDilemma.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=uaaC57tcci0",
                    Review = "A chilling look at the manipulation behind social platforms. It serves as an urgent call to rethink our digital lives."
                });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 3,
                    Title = "13th",
                    Director = "Ava DuVernay",
                    Category = "History",
                    Description = "An exploration of the U.S. prison system and racial inequality.",
                    Language = Language.English,
                    Duration = 100,
                    Year = 2016,
                    ImageUrl = "/images/13th.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=krfcq5pF8u8",
                    Review = "A powerful and essential documentary about systemic racism. It highlights the deep-rooted issues within the American justice system."
                });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 4,
                    Title = "Free Solo",
                    Director = "Elizabeth Chai Vasarhelyi, Jimmy Chin",
                    Category = "Adventure",
                    Description = "Follows Alex Honnold as he attempts to climb El Capitan without ropes.",
                    Language = Language.English,
                    Duration = 100,
                    Year = 2018,
                    ImageUrl = "/images/freeSolo.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=urRVZ4SW7WU",
                    Review = "Gripping and visually stunning—a triumph of human endurance. The intensity and beauty of the climb are unmatched."
                });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 5,
                    Title = "My Octopus Teacher",
                    Director = "Pippa Ehrlich, James Reed",
                    Category = "Wildlife",
                    Description = "A filmmaker forms an unusual bond with an octopus in a kelp forest.",
                    Language = Language.English,
                    Duration = 85,
                    Year = 2020,
                    ImageUrl = "/images/myOctopusTeacher.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=3s0LTDhqe5A",
                    Review = "A beautiful and emotional underwater tale of connection. The bond between man and octopus is touching and profound."
                });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 6,
                    Title = "This Is It",
                    Director = "Kenny Ortega",
                    Category = "Music",
                    Description = "A behind-the-scenes look at Michael Jackson's final concert preparations.",
                    Language = Language.English,
                    Duration = 111,
                    Year = 2009,
                    ImageUrl = "/images/thisIsIt.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=zUniG6F_RzY",
                    Review = "An intimate tribute to the King of Pop's final masterpiece. It gives fans an unparalleled look into Michael's vision and artistry."
                });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 7,
                    Title = "March of the Penguins",
                    Director = "Luc Jacquet",
                    Category = "Nature",
                    Description = "A portrayal of emperor penguins’ annual journey through the Antarctic.",
                    Language = Language.English,
                    Duration = 80,
                    Year = 2005,
                    ImageUrl = "/images/marchOfThePenguins.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=ohL8rF_jluA",
                    Review = "Heartwarming and visually stunning—penguins as you've never seen them. The journey of survival and love is deeply moving."
                });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 8,
                    Title = "Inside Job",
                    Director = "Charles Ferguson",
                    Category = "Finance",
                    Description = "Exposes the shocking truth behind the 2008 financial crisis.",
                    Language = Language.English,
                    Duration = 108,
                    Year = 2010,
                    ImageUrl = "/images/insideJob.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=FzrBurlJUNk",
                    Review = "A brilliant and sobering analysis of corporate greed and corruption. It provides a detailed and terrifying account of the financial collapse."
                });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 9,
                    Title = "How the Universe Works",
                    Director = "Louise Say (series producer)",
                    Category = "Nature",
                    Description = "A science documentary series explaining the inner workings of the cosmos.",
                    Language = Language.English,
                    Duration = 430,
                    Year = 2010,
                    ImageUrl = "/images/howTheUniverseWorks.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=Q1frjo2yvrM",
                    Review = "Fascinating insights into cosmic phenomena presented clearly and vividly. It's an awe-inspiring journey through space and time."
                });

            modelBuilder.Entity<Documentary>().HasData(
                new Documentary
                {
                    Id = 10,
                    Title = "The Vietnam War",
                    Director = "Ken Burns, Lynn Novick",
                    Category = "History",
                    Description = "An in-depth documentary series covering the history of the Vietnam War.",
                    Language = Language.English,
                    Duration = 1080,
                    Year = 2017,
                    ImageUrl = "/images/theVietnamWar.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=iWFzaUlZz-k",
                    Review = "Comprehensive, emotional, and brutally honest—a monumental achievement. The series paints an unflinching portrait of the war's devastating impact."
                });


            modelBuilder.Entity<Review>().HasData(
                    new Review
                    {
                        Id = 1,
                        DocumentaryId = 1,
                        Rating = 4,
                        DatePosted = new DateTime(2024, 01, 01)
                    },
                     new Review
                     {
                         Id = 2,
                         DocumentaryId = 3,
                         Rating = 2,
                         DatePosted = new DateTime(2024, 03, 01)
                     },
                          new Review
                          {
                              Id = 3,
                              DocumentaryId = 6,
                              Rating = 4,
                              DatePosted = new DateTime(2024, 03, 01)
                          },
                                       new Review
                                       {
                                           Id = 4,
                                           DocumentaryId = 7,
                                           Rating = 1,
                                           DatePosted = new DateTime(2024, 03, 01)
                                       },
            new Review
            {
                Id = 5,
                DocumentaryId = 3,
                Rating = 4,
                DatePosted = new DateTime(2024, 02, 15)
            });

        }
    }
}
