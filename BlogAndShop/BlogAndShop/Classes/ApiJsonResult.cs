namespace BlogAndShop.Classes
{
    public class ApiJsonResult<T>
    {
        public string[] description { get; set; }
        public int status_code { get; set; }
        public bool ok { get; set; }
        public object data { get; set; }
    }
}