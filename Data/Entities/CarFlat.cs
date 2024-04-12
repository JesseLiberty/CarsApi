namespace Cars.Data.Entities
{
    public class CarFlat : Car
    {
        public int? car_id { get; set; }
        public int? option_int { get; set; }
        public string? option_name { get; set; }
        public float option_price { get; set; }
    }
}
