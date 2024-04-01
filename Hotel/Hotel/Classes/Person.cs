namespace Hotel.Classes
{
    internal class Person
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Name { get; set; }
        public DateTime IncomeTime { get; set; }
        public DateTime OutcomeTime { get; set; }

        public Person(int id, int statusId, string name, DateTime incomeTime, DateTime outcomeTime)
        {
            Id = id;
            StatusId = statusId;
            Name = name;
            IncomeTime = incomeTime;
            OutcomeTime = outcomeTime;
        }
    }
}
