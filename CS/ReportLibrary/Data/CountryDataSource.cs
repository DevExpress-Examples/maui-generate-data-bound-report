namespace ReportLibrary.Data {
    public class CountryDataSource : List<CountryData> {
        public CountryDataSource() {
            List<CountryData> sales = new List<CountryData>() {
                //new CountryData(0, -1, "Northern Europe", 1811151),
                new CountryData(1, 0, "Norway", 385207),
                new CountryData(2, 0, "Sweden", 528447),
                new CountryData(3, 0, "Denmark", 42951),
                new CountryData(4, 0, "Finland", 338455),
                new CountryData(5, 0, "Iceland", 103000),
                new CountryData(6, 0, "Ireland", 84421),
                new CountryData(7, 0, "United Kingdom", 243610),

                //new CountryData(17, -1, "Southern Europe", 1316300),
                new CountryData(18, 17, "Spain", 505990),
                new CountryData(19, 17, "Portugal", 92212),
                new CountryData(20, 17, "Greece", 131957),
                new CountryData(21, 17, "Italy", 301230),
                new CountryData(22, 17, "Malta", 316),
                new CountryData(23, 17, "San Marino", 61.2),
                new CountryData(25, 17, "Serbia", 88499),

                //new CountryData(26, -1, "North America", 24490000),
                new CountryData(27, 26, "USA", 9522055),
                new CountryData(28, 26, "Canada", 9984670),

               // new CountryData(29, -1, "South America", 17840000),
                new CountryData(30, 29, "Argentina", 2780400),
                new CountryData(31, 29, "Brazil", 8514215),

               // new CountryData(32, -1, "East Asia", 11796365),
                new CountryData(34, 32, "India", 3287263),
                new CountryData(35, 32, "Japan", 377975),
                new CountryData(36, 32, "China", 9597000)
            };
            this.AddRange(sales);
        }
    }
}
