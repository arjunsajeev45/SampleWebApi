namespace SampleWebApi.Model
{
    public class Passport
    {
        public int Id { get; set; }
        public string ? PassportNumber { get; set; }
        public int PersonId { get; set; }//FK
        public Person ? Person { get; set; }//Navigation
    }
}
