namespace SampleWebApi.Model
{
    public class Person
    {
        public int Id { get; set; }//PK
        public string ? Name { get; set; }

        public int ? Age{ get; set; }

        public string ? MoblileNo { get; set; }
        public Passport ? Passport { get; set; }//Navigation
    }
}
