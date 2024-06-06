namespace ReportLibrary.Data {
    public class CountryData {
        public CountryData(int regionId, int parentRegionId, string region, double area) {
            RegionID = regionId;
            ParentRegionID = parentRegionId;
            Region = region;
            Area = area;
        }
        public int RegionID { get; set; }
        public int ParentRegionID { get; set; }
        public string Region { get; set; }
        public double Area { get; set; }
    }
}
