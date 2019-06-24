using System.Collections.Generic;

namespace HotelApp.Models
{
    public class Hotel
    {
        public long Guests { get; set; }
        public long Rooms { get; set; }
        public IEnumerable<bool> RoomLights => GetRoomLights(Guests, Rooms);

        private IEnumerable<bool> GetRoomLights(long guests, long rooms)
        {
            var roomLights = new bool[rooms];

            for (long guestNum = 1; guestNum <= guests; guestNum++)
            {
                long lightsToFlip = rooms / guestNum;

                for (long flip = 1; flip <= lightsToFlip; flip++)
                {
                    long roomNum = guestNum * flip - 1;

                    roomLights[roomNum] = !roomLights[roomNum];
                }
            }

            return roomLights;
        }
    }
}
