using PexelsDotNetSDK.Models;

namespace CA3_X00167885;

public class StoredPhotosService
{
    public List<Photo> PhotosStored { get; set; } = [];
    public void AddPhoto(Photo photo)
    {
        if (PhotosStored.Count == 0)
        {
            PhotosStored.Add(photo);
        }
        else
        {
            bool found = false;
            foreach (Photo p in PhotosStored)
            {
                if (photo.id == p.id)
                {
                    found = true;
                }
            }
            if (!found)
            {
                PhotosStored.Add(photo);
            }
        }
    }
}
