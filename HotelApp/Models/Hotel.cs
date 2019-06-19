namespace HotelApp.Models
{
    public class Hotel
    {
        public long Guests { get; set; }
        public long Rooms { get; set; }
        public bool[] RoomLights => GetRoomLights(Guests, Rooms);

        private bool[] GetRoomLights(long guests, long rooms)
        {
            bool[] roomLights = new bool[rooms];

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
