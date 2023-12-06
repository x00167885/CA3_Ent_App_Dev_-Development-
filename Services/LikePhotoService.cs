using PexelsDotNetSDK.Models;

namespace CA3_X00167885;

public class LikePhotoService
{
    public List<Photo> LikedPhotos { get; set; } = [];
    public void AddLikedPhoto(Photo photo)
    {
        if (LikedPhotos.Count == 0)
        {
            LikedPhotos.Add(photo);
        }
        else
        {
            bool found = false;
            foreach (Photo p in LikedPhotos)
            {
                if (photo.id == p.id)
                {
                    found = true;
                }
            }
            if (!found)
            {
                LikedPhotos.Add(photo);
            }
        }
    }
    public void RemoveLikedPhoto(Photo photo)
    {
        if (LikedPhotos.Count != 0)
        {
            LikedPhotos.Remove(photo);
        }
    }
}