using ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IImageRepository
    {
        // In dealing with images we mostly need 1 of the following methods:
        //  - Create (upload) a new image
        //  - Delete a single image by image ID
        //  - Delete a single image by image URL
        //  - Delete all the images from a certain hotel room
        //  - Get all the images from a specific hotel room

        public Task<int> CreateImage(ImageDTO imageDTO);

        public Task<int> DeleteImageByImageId(int imageId);

        public Task<int> DeleteImagesByRoomId(int roomId);

        public Task<int> DeleteImageByImageUrl(string imageUrl);

        public Task<IEnumerable<ImageDTO>> GetHotelRoomImages(int roomId);
    }
}
