namespace HotelApp.Models
{
    public class Hotel
    {
        public long Guests { get; set; }
        public long Rooms { get; set; }
        public long Lights => CountLights(Guests, Rooms);

        private long CountLights(long guests, long rooms)
        {
            bool[] roomLights = new bool[rooms];

            long lights = 0;

            for (long guestNum = 1; guestNum <= guests; guestNum++)
            {
                long flipsByPerson = rooms / guestNum;

                for (long flip = 1; flip <= flipsByPerson; flip++)
                {
                    long roomNum = guestNum * flip - 1;

                    roomLights[roomNum] = !roomLights[roomNum];

                    if (roomLights[roomNum])
                        lights++;
                    else
                        lights--;
                }
            }

            return lights;
        }
    }
}
