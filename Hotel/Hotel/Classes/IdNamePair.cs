﻿namespace Hotel.Classes
{
    public class IdNamePair
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IdNamePair(Person person)
        {
            Id = person.Id;
            Name = person.Name;
        }
    }
}
