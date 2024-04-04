namespace Hotel.Classes
{
    public class Person
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public DateTime IncomeTime { get; set; }
        public DateTime OutcomeTime { get; set; }
        public byte[] Picture { get; set; }


        static public byte[] PictureToByteArr(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        static public Image ByteArrToPicture(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        public Person(int id, int statusId, string name, DateTime incomeTime, DateTime outcomeTime, byte[] picture)
        {
            Id = id;
            StatusId = statusId;
            Name = name;
            IncomeTime = incomeTime;
            OutcomeTime = outcomeTime;
            Picture = picture;
        }
    }
}
