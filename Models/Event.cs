namespace WorldCupSoccer.Models
{
    public class Event
    {
        public int id {get; set;}
        public int year {get; set;}
        public string hostCountry {get; set;}
        public string firstPlace {get; set;}
        public string firstImageName {get; set;}
        public string secondPlace {get; set;}
        public string secondImageName {get; set;}
        public string thirdPlace {get; set;}
        public string thirdImageName {get; set;}

        public Event(int idParam, int yearParam, string hostCountryParam, string firstPlaceParam,
                        string secondPlaceParam, string thirdPlaceParam, string firstImageNameParam,
                        string secondImageNameParam, string thirdImageNameParam) {
            this.id = idParam;
            this.year = yearParam;
            this.hostCountry = hostCountryParam;
            this.firstPlace = firstPlaceParam;
            this.secondPlace = secondPlaceParam;
            this.thirdPlace = thirdPlaceParam;
            this.firstImageName = firstImageNameParam;
            this.secondImageName = secondImageNameParam;
            this.thirdImageName = thirdImageNameParam;
        }
        
        // Necessary to avoid the error "No suitable constructor found for entity type 'Nation'."
        protected Event() {

        }
    }
}