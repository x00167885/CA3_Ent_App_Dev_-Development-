using PexelsDotNetSDK.Models;

namespace CA3_X00167885;

public class LikeVideoService
{
    public List<Video> LikedVideos { get; set; } = [];
    public void AddLikedVideo(Video video)
    {
        if (LikedVideos.Count == 0)
        {
            LikedVideos.Add(video);
        }
        else
        {
            bool found = false;
            foreach (Video v in LikedVideos)
            {
                if (video.id == v.id)
                {
                    found = true;
                }
            }
            if (!found)
            {
                LikedVideos.Add(video);
            }
        }
    }
    public void RemoveLikedPhoto(Video video)
    {
        if (LikedVideos.Count != 0)
        {
            LikedVideos.Remove(video);
        }
    }
}
