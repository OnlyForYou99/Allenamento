namespace Bio_Agriturismo.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool HasRoom { get; set; }
        public int Age { get; set; }
        public int RoomId { get; set; }
    }
}
