using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.webui.Extensions
{
    public static class Extension
    {
        public const string _MESSAGE = "Message";

        public static void SetMessage<T>(this ITempDataDictionary @this, string key, T value) where T:class
        {
            @this[_MESSAGE] = JsonConvert.SerializeObject(value);
        }

        public static T GetMessage<T>(this ITempDataDictionary @this, string key) where T : class
        {
            object o;
            @this.TryGetValue(key, out o);
            return o == null ? null : JsonConvert.DeserializeObject<T>((string)o);
        }
            
    }
}
