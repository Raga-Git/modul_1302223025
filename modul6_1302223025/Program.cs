using System.Collections.Generic;
using System.Data;

public class Program
{
    public class random
    {
        public int idramdom()
        {
            Random id = new Random();
            return id.Next(10000, 99999);
        }
    }
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            random newID = new random();
            id = newID.idramdom();
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.username = username;
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++) 
            {
                total += uploadedVideos[i].getPlaycount();
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video) 
        { 
            uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine($"User : {username}");
            for (int i = 0;i < uploadedVideos.Count; i++) {
                Console.WriteLine($"Video : {uploadedVideos[i].getTitle()}");
       
            }
        }
    }

    public class SayaTubeVideo 
    {
        private int id;
        private string title;
        private int playcount;

        public SayaTubeVideo(string title)
        {
            random addID = new random();
            this.title = title;
            id = addID.idramdom();
            playcount = 0;
        }
        public void increasePlaycount(int playcount) 
        { 
            this.playcount = playcount; 
        }  
        public void printVideoDetail()
        {
            Console.WriteLine($"id : {id}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Playcount : {playcount}");
        }
        public int getPlaycount()
        {
            return playcount;
        }
        public string getTitle()
        {
            return title;
        }
    }
    private static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Raga");
        SayaTubeVideo video1 = new SayaTubeVideo("Marvel 1");
        video1.increasePlaycount(1);
        user.AddVideo(video1);

        SayaTubeVideo video2 = new SayaTubeVideo("Marvel 2");
        video2.increasePlaycount(1);
        user.AddVideo(video2);

        SayaTubeVideo video3 = new SayaTubeVideo("Marvel 3");
        video3.increasePlaycount(1);
        user.AddVideo(video3);

        SayaTubeVideo video4 = new SayaTubeVideo("Marvel 4");
        video4.increasePlaycount(1);
        user.AddVideo(video4);

        SayaTubeVideo video5 = new SayaTubeVideo("Marvel 5");
        video5.increasePlaycount(1);
        user.AddVideo(video5);

        SayaTubeVideo video6 = new SayaTubeVideo("Marvel 6");
        video6.increasePlaycount(1);
        user.AddVideo(video6);
        
        SayaTubeVideo video7 = new SayaTubeVideo("Marvel 7");
        video7.increasePlaycount(1);
        user.AddVideo(video7);

        SayaTubeVideo video8 = new SayaTubeVideo("Marvel 8");
        video8.increasePlaycount(1);
        user.AddVideo(video8);

        SayaTubeVideo video9 = new SayaTubeVideo("Marvel 9");
        video9.increasePlaycount(1);
        user.AddVideo(video9);

        SayaTubeVideo video10 = new SayaTubeVideo("Marvel 10");
        video10.increasePlaycount(1);
        user.AddVideo(video10);

        user.GetTotalVideoPlayCount();
        user.PrintAllVideoPlaycount();
    }
}