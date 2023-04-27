using Newtonsoft.Json;

namespace LoginProject.Models
{
    public static class SessionHelper   
    {
        public static int Count { get; set; } = new int();
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            //session.SetString("Ad", "Şamil");
            //session.SetInt32("Num", 1);
            //var ism = session.GetString("ad");
            //var num = session.GetInt32("Num");
            //List<string> values = new List<string>();
           // session.SetString("Val", JsonConvert.SerializeObject (values));
           
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
