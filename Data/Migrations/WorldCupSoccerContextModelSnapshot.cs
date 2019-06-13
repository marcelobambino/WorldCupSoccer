﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldCupSoccer.Data;

namespace WorldCupSoccer.Data.Migrations
{
    [DbContext(typeof(WorldCupSoccerContext))]
    partial class WorldCupSoccerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("WorldCupSoccer.Models.Event", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("firstImageName")
                        .HasColumnName("FirstImageName");

                    b.Property<string>("firstPlace")
                        .HasColumnName("FirstPlace");

                    b.Property<string>("hostCountry")
                        .HasColumnName("HostCountry");

                    b.Property<string>("secondImageName")
                        .HasColumnName("SecondImageName");

                    b.Property<string>("secondPlace")
                        .HasColumnName("SecondPlace");

                    b.Property<string>("thirdImageName")
                        .HasColumnName("ThirdImageName");

                    b.Property<string>("thirdPlace")
                        .HasColumnName("ThirdPlace");

                    b.Property<int>("year")
                        .HasColumnName("Year");

                    b.HasKey("id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            id = 1,
                            firstImageName = "uruguay.jpg",
                            firstPlace = "Uruguay",
                            hostCountry = "Uruguay",
                            secondImageName = "argentina.jpg",
                            secondPlace = "Argentina",
                            thirdImageName = "united_states.jpg",
                            thirdPlace = "United States",
                            year = 1930
                        },
                        new
                        {
                            id = 2,
                            firstImageName = "italy.jpg",
                            firstPlace = "Italy",
                            hostCountry = "Italy",
                            secondImageName = "germany.jpg",
                            secondPlace = "Germany",
                            thirdImageName = "austria.jpg",
                            thirdPlace = "Austria",
                            year = 1934
                        },
                        new
                        {
                            id = 3,
                            firstImageName = "italy.jpg",
                            firstPlace = "Italy",
                            hostCountry = "France",
                            secondImageName = "hungary.jpg",
                            secondPlace = "Hungary",
                            thirdImageName = "brazil.jpg",
                            thirdPlace = "Brazil",
                            year = 1938
                        },
                        new
                        {
                            id = 4,
                            firstImageName = "uruguay.jpg",
                            firstPlace = "Uruguay",
                            hostCountry = "Brazil",
                            secondImageName = "brazil.jpg",
                            secondPlace = "Brazil",
                            thirdImageName = "sweden.jpg",
                            thirdPlace = "Sweden",
                            year = 1950
                        },
                        new
                        {
                            id = 5,
                            firstImageName = "germany.jpg",
                            firstPlace = "Germany",
                            hostCountry = "Switzerland",
                            secondImageName = "hungary.jpg",
                            secondPlace = "Hungary",
                            thirdImageName = "austria.jpg",
                            thirdPlace = "Austria",
                            year = 1954
                        },
                        new
                        {
                            id = 6,
                            firstImageName = "brazil.jpg",
                            firstPlace = "Brazil",
                            hostCountry = "Sweden",
                            secondImageName = "sweden.jpg",
                            secondPlace = "Sweden",
                            thirdImageName = "france.jpg",
                            thirdPlace = "France",
                            year = 1958
                        },
                        new
                        {
                            id = 7,
                            firstImageName = "brazil.jpg",
                            firstPlace = "Brazil",
                            hostCountry = "Chile",
                            secondImageName = "czechoslovakia.jpg",
                            secondPlace = "Czechoslovakia",
                            thirdImageName = "chile.jpg",
                            thirdPlace = "Chile",
                            year = 1962
                        },
                        new
                        {
                            id = 8,
                            firstImageName = "england.jpg",
                            firstPlace = "England",
                            hostCountry = "England",
                            secondImageName = "germany.jpg",
                            secondPlace = "Germany",
                            thirdImageName = "portugal.jpg",
                            thirdPlace = "Portugal",
                            year = 1966
                        },
                        new
                        {
                            id = 9,
                            firstImageName = "brazil.jpg",
                            firstPlace = "Brazil",
                            hostCountry = "Mexico",
                            secondImageName = "italy.jpg",
                            secondPlace = "Italy",
                            thirdImageName = "germany.jpg",
                            thirdPlace = "Germany",
                            year = 1970
                        },
                        new
                        {
                            id = 10,
                            firstImageName = "germany.jpg",
                            firstPlace = "Germany",
                            hostCountry = "Germany",
                            secondImageName = "netherlands.jpg",
                            secondPlace = "Netherlands",
                            thirdImageName = "poland.jpg",
                            thirdPlace = "Poland",
                            year = 1974
                        },
                        new
                        {
                            id = 11,
                            firstImageName = "argentina.jpg",
                            firstPlace = "Argentina",
                            hostCountry = "Argentina",
                            secondImageName = "netherlands.jpg",
                            secondPlace = "Netherlands",
                            thirdImageName = "brazil.jpg",
                            thirdPlace = "Brazil",
                            year = 1978
                        },
                        new
                        {
                            id = 12,
                            firstImageName = "italy.jpg",
                            firstPlace = "Italy",
                            hostCountry = "Spain",
                            secondImageName = "germany.jpg",
                            secondPlace = "Germany",
                            thirdImageName = "poland.jpg",
                            thirdPlace = "Poland",
                            year = 1982
                        },
                        new
                        {
                            id = 13,
                            firstImageName = "argentina.jpg",
                            firstPlace = "Argentina",
                            hostCountry = "Mexico",
                            secondImageName = "germany.jpg",
                            secondPlace = "Germany",
                            thirdImageName = "france.jpg",
                            thirdPlace = "France",
                            year = 1986
                        },
                        new
                        {
                            id = 14,
                            firstImageName = "germany.jpg",
                            firstPlace = "Germany",
                            hostCountry = "Italy",
                            secondImageName = "argentina.jpg",
                            secondPlace = "Argentina",
                            thirdImageName = "italy.jpg",
                            thirdPlace = "Italy",
                            year = 1990
                        },
                        new
                        {
                            id = 15,
                            firstImageName = "brazil.jpg",
                            firstPlace = "Brazil",
                            hostCountry = "United States",
                            secondImageName = "italy.jpg",
                            secondPlace = "Italy",
                            thirdImageName = "sweden.jpg",
                            thirdPlace = "Sweden",
                            year = 1994
                        },
                        new
                        {
                            id = 16,
                            firstImageName = "france.jpg",
                            firstPlace = "France",
                            hostCountry = "France",
                            secondImageName = "brazil.jpg",
                            secondPlace = "Brazil",
                            thirdImageName = "croatia.jpg",
                            thirdPlace = "Croatia",
                            year = 1998
                        },
                        new
                        {
                            id = 17,
                            firstImageName = "brazil.jpg",
                            firstPlace = "Brazil",
                            hostCountry = "South Korea / Japan",
                            secondImageName = "germany.jpg",
                            secondPlace = "Germany",
                            thirdImageName = "turkey.jpg",
                            thirdPlace = "Turkey",
                            year = 2002
                        },
                        new
                        {
                            id = 18,
                            firstImageName = "italy.jpg",
                            firstPlace = "Italy",
                            hostCountry = "Germany",
                            secondImageName = "france.jpg",
                            secondPlace = "France",
                            thirdImageName = "germany.jpg",
                            thirdPlace = "Germany",
                            year = 2006
                        },
                        new
                        {
                            id = 19,
                            firstImageName = "spain.jpg",
                            firstPlace = "Spain",
                            hostCountry = "South Africa",
                            secondImageName = "netherlands.jpg",
                            secondPlace = "Netherlands",
                            thirdImageName = "germany.jpg",
                            thirdPlace = "Germany",
                            year = 2010
                        },
                        new
                        {
                            id = 20,
                            firstImageName = "germany.jpg",
                            firstPlace = "Germany",
                            hostCountry = "Brazil",
                            secondImageName = "argentina.jpg",
                            secondPlace = "Argentina",
                            thirdImageName = "netherlands.jpg",
                            thirdPlace = "Netherlands",
                            year = 2014
                        },
                        new
                        {
                            id = 21,
                            firstImageName = "france.jpg",
                            firstPlace = "France",
                            hostCountry = "Russia",
                            secondImageName = "croatia.jpg",
                            secondPlace = "Croatia",
                            thirdImageName = "belgium.jpg",
                            thirdPlace = "Belgium",
                            year = 2018
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
