namespace HotelApp.Models
{
    public class Hotel
    {
        public long Guests { get; set; }
        public long Rooms { get; set; }
        public bool[] RoomLights => Utilities.Electrical.GetRoomLights(Guests, Rooms);
    }
}
