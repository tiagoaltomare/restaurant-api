namespace Restaurants.WebApi
{
    public class ResponseData
    {
        public ResponseData(object obj)
        {
            Data = obj;
        }
        public object Data { get; set; }
    }
}
