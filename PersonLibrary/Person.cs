using System;

namespace PersonLibrary
{
    /// <summary>
    /// Template containing: FirstName, LastName, StartDate, Rating.
    /// </summary>
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public int Rating { get; set; }
    }
}