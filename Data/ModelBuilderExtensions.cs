using WorldCupSoccer.Models;
using Microsoft.EntityFrameworkCore;

namespace WorldCupSoccer.Data
{
    public static class ModelBuilderExtensions 
    {
        // The seed method itself is called in the WorldCupSoccerContext.OnModelCreating method
        public static ModelBuilder Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Event>().HasData(
                new Event(1, 1930, "Uruguay", "Uruguay", "Argentina", "United States", "uruguay.jpg", "argentina.jpg", "united_states.jpg"),
                new Event(2, 1934, "Italy", "Italy", "Germany", "Austria", "italy.jpg", "germany.jpg", "austria.jpg"),
                new Event(3, 1938, "France", "Italy", "Hungary", "Brazil", "italy.jpg", "hungary.jpg", "brazil.jpg"),
                new Event(4, 1950, "Brazil", "Uruguay", "Brazil", "Sweden", "uruguay.jpg", "brazil.jpg", "sweden.jpg"),
                new Event(5, 1954, "Switzerland" ,"Germany", "Hungary", "Austria", "germany.jpg", "hungary.jpg", "austria.jpg"),
                new Event(6, 1958, "Sweden", "Brazil", "Sweden", "France", "brazil.jpg", "sweden.jpg", "france.jpg"),
                new Event(7, 1962, "Chile", "Brazil", "Czechoslovakia", "Chile", "brazil.jpg", "czechoslovakia.jpg", "chile.jpg"),
                new Event(8, 1966, "England", "England", "Germany", "Portugal", "england.jpg", "germany.jpg", "portugal.jpg"),
                new Event(9, 1970, "Mexico", "Brazil", "Italy", "Germany", "brazil.jpg", "italy.jpg", "germany.jpg"),
                new Event(10, 1974, "Germany", "Germany", "Netherlands", "Poland", "germany.jpg", "netherlands.jpg", "poland.jpg"),
                new Event(11, 1978, "Argentina", "Argentina", "Netherlands", "Brazil", "argentina.jpg", "netherlands.jpg", "brazil.jpg"),
                new Event(12, 1982, "Spain", "Italy", "Germany", "Poland", "italy.jpg", "germany.jpg", "poland.jpg"),
                new Event(13, 1986, "Mexico", "Argentina", "Germany", "France", "argentina.jpg", "germany.jpg", "france.jpg"),
                new Event(14, 1990, "Italy", "Germany", "Argentina", "Italy", "germany.jpg", "argentina.jpg", "italy.jpg"),
                new Event(15, 1994, "United States", "Brazil", "Italy", "Sweden", "brazil.jpg", "italy.jpg", "sweden.jpg"),
                new Event(16, 1998, "France", "France", "Brazil", "Croatia", "france.jpg", "brazil.jpg", "croatia.jpg"),
                new Event(17, 2002, "South Korea / Japan", "Brazil", "Germany", "Turkey", "brazil.jpg", "germany.jpg", "turkey.jpg"),
                new Event(18, 2006, "Germany", "Italy", "France", "Germany", "italy.jpg", "france.jpg", "germany.jpg"),
                new Event(19, 2010, "South Africa", "Spain", "Netherlands", "Germany", "spain.jpg", "netherlands.jpg", "germany.jpg"),
                new Event(20, 2014, "Brazil", "Germany", "Argentina", "Netherlands", "germany.jpg", "argentina.jpg", "netherlands.jpg"),
                new Event(21, 2018, "Russia", "France", "Croatia", "Belgium", "france.jpg", "croatia.jpg", "belgium.jpg")                                                                                                                                                                                                                                                                                                                                        
            );

            return modelBuilder;
        }
    }
}