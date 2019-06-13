using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldCupSoccer.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Year = table.Column<int>(nullable: false),
                    HostCountry = table.Column<string>(nullable: true),
                    FirstPlace = table.Column<string>(nullable: true),
                    FirstImageName = table.Column<string>(nullable: true),
                    SecondPlace = table.Column<string>(nullable: true),
                    SecondImageName = table.Column<string>(nullable: true),
                    ThirdPlace = table.Column<string>(nullable: true),
                    ThirdImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 1, "uruguay.jpg", "Uruguay", "Uruguay", "argentina.jpg", "Argentina", "united_states.jpg", "United States", 1930 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 19, "spain.jpg", "Spain", "South Africa", "netherlands.jpg", "Netherlands", "germany.jpg", "Germany", 2010 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 18, "italy.jpg", "Italy", "Germany", "france.jpg", "France", "germany.jpg", "Germany", 2006 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 17, "brazil.jpg", "Brazil", "South Korea / Japan", "germany.jpg", "Germany", "turkey.jpg", "Turkey", 2002 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 16, "france.jpg", "France", "France", "brazil.jpg", "Brazil", "croatia.jpg", "Croatia", 1998 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 15, "brazil.jpg", "Brazil", "United States", "italy.jpg", "Italy", "sweden.jpg", "Sweden", 1994 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 14, "germany.jpg", "Germany", "Italy", "argentina.jpg", "Argentina", "italy.jpg", "Italy", 1990 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 13, "argentina.jpg", "Argentina", "Mexico", "germany.jpg", "Germany", "france.jpg", "France", 1986 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 12, "italy.jpg", "Italy", "Spain", "germany.jpg", "Germany", "poland.jpg", "Poland", 1982 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 20, "germany.jpg", "Germany", "Brazil", "argentina.jpg", "Argentina", "netherlands.jpg", "Netherlands", 2014 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 11, "argentina.jpg", "Argentina", "Argentina", "netherlands.jpg", "Netherlands", "brazil.jpg", "Brazil", 1978 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 9, "brazil.jpg", "Brazil", "Mexico", "italy.jpg", "Italy", "germany.jpg", "Germany", 1970 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 8, "england.jpg", "England", "England", "germany.jpg", "Germany", "portugal.jpg", "Portugal", 1966 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 7, "brazil.jpg", "Brazil", "Chile", "czechoslovakia.jpg", "Czechoslovakia", "chile.jpg", "Chile", 1962 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 6, "brazil.jpg", "Brazil", "Sweden", "sweden.jpg", "Sweden", "france.jpg", "France", 1958 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 5, "germany.jpg", "Germany", "Switzerland", "hungary.jpg", "Hungary", "austria.jpg", "Austria", 1954 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 4, "uruguay.jpg", "Uruguay", "Brazil", "brazil.jpg", "Brazil", "sweden.jpg", "Sweden", 1950 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 3, "italy.jpg", "Italy", "France", "hungary.jpg", "Hungary", "brazil.jpg", "Brazil", 1938 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 2, "italy.jpg", "Italy", "Italy", "germany.jpg", "Germany", "austria.jpg", "Austria", 1934 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 10, "germany.jpg", "Germany", "Germany", "netherlands.jpg", "Netherlands", "poland.jpg", "Poland", 1974 });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "FirstImageName", "FirstPlace", "HostCountry", "SecondImageName", "SecondPlace", "ThirdImageName", "ThirdPlace", "Year" },
                values: new object[] { 21, "france.jpg", "France", "Russia", "croatia.jpg", "Croatia", "belgium.jpg", "Belgium", 2018 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
