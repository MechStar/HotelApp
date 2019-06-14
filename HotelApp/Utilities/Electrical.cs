﻿namespace HotelApp.Utilities
{
    public static class Electrical
    {
        public static bool[] GetRoomLights(long guests, long rooms)
        {
            bool[] roomLights = new bool[rooms];

            for (long guestNum = 1; guestNum <= guests; guestNum++)
            {
                long flipsByPerson = rooms / guestNum;

                for (long flip = 1; flip <= flipsByPerson; flip++)
                {
                    long roomNum = guestNum * flip - 1;

                    roomLights[roomNum] = !roomLights[roomNum];
                }
            }

            return roomLights;
        }
    }
}
