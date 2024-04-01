namespace Hotel.Classes
{
    internal class Status
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

        public Status(int id, string statusName)
        {
            Id = id;
            StatusName = statusName;
        }
    }
}
