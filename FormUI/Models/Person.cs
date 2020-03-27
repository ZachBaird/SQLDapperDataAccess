namespace FormUI.Models
{
    // Represents the columns from the db.
    public class Person
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullInfo 
        { 
            get
            {
                // Ex. John Doe
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
