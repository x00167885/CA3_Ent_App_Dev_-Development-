using PexelsDotNetSDK.Models;

namespace CA3_X00167885;

public class StoredVideosService
{
    public List<Video> VideosStored { get; set; } = [];
    public void AddVideo(Video video)
    {
        if (VideosStored.Count == 0)
        {
            VideosStored.Add(video);
        }
        else
        {
            bool found = false;
            foreach (Video v in VideosStored)
            {
                if (video.id == v.id)
                {
                    found = true;
                }
            }
            if (!found)
            {
                VideosStored.Add(video);
            }
        }
    }
}
