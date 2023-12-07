

using System.Diagnostics.Metrics;

namespace SpotiflyApp.Model
{
    internal class Artist : Spotifly
    {//Properties Name, Country, Birthday
     //Method GetAge()

        public DateOnly Birthday = new DateOnly();
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        //public string Kunstner {get { return _artist; } set { _artist = value; }}
        //writing the Age method into a property
        public int Age
        {
            get
            {
                //getting todays date
                DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);

                //finding the difference from this year and birthday year
                int age = dateNow.Year - Birthday.Year;

                // checking if the birthday has already happened. If it has, then deduct oine from the result
                if (dateNow.DayOfYear < Birthday.DayOfYear)
                {
                    age--;
                }

                return age;
            }
            set { Age = value; }
        }
    }
}
