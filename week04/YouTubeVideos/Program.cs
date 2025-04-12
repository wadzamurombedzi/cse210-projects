using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!\n");
        List<Video> videos = new();

        void DisplayVideoData()
        {
            int count = 0;
            foreach (Video video in videos)
            {
                count++;
                Console.WriteLine($"Video0{count} - 4k");
                video.DisplayMetaData();
                Console.WriteLine("\nComments:");
                video.DisplayComment();
            }
        }

    
        Video video1 = new();
        Video video2 = new();
        Video video3 = new();
    
        Comment comment = new("Samuel", "Love you, legend is back!");

        // First Video for 12minutes
        video1.SetVideoMeta("Khauf", "Official Traiter | Prime Video India", 12);
        video1.SetComment(comment);
    
        comment = new("bblorettafolkes", "So happy for Chum");
        video1.SetComment(comment);
    
        comment = new("Regina", "You made my day");
        video1.SetComment(comment);
    
        videos.Add(video1);

        // Second video for 90minutes
        video2.SetVideoMeta("Charlotte Hemmings", "Beauty and the Billionaire", 90);
        comment = new("Melon", "I finished watching, Beautiful love story. Beutiful cast");
        video2.SetComment(comment);
    
        comment = new("Suzie", "Very good movie, beautiful plot, good actors");
        video2.SetComment(comment);
    
        comment = new("Rosemary", "Good movie...wasn't too sure from the beginning. Glad i gave it a chance");
        video2.SetComment(comment);
        ////////////////////////////
        videos.Add(video2);

        // Third video for 96minutes
        video3.SetVideoMeta("White444", "Husband's Terrible Lie", 96);
        comment = new("Angelwr", "People arae saying there is no ending 😂 moving on now");
        video3.SetComment(comment);
    
        comment = new("Essence", "Thanks for the upload but you where wrong for that ending tho i was glued 🤣🤣🤣");
        video3.SetComment(comment);
    
        comment = new("Thaliakhi", "Where is the rest of the movie");
        video3.SetComment(comment);
    
        videos.Add(video3);
        DisplayVideoData();

    }
}