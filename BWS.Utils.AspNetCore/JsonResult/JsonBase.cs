using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BWS.Utils.AspNetCore.JsonResult {

    /// <summary>
    /// Jsonbase for response.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [JsonObject]
    public class JsonBase<T> : Dictionary<string, object> where T : struct {

        /// <summary>
        /// Create jsonbase in default type.
        /// </summary>
        public JsonBase() {
            if (!typeof(T).IsEnum)
                throw new ArgumentException("T must be the enum type.");
            this.Status = default(T);
            this.Message = null;
            this.Content = null;
        }

        /// <summary>
        /// Create jsonbase with message.
        /// </summary>
        /// <param name="message"></param>
        public JsonBase(string message) : base() => this.Message = message;

        /// <summary>
        /// json element with name 'status', type is T (value type).
        /// </summary>
        [JsonProperty( "status")]
        public T Status {
            get => (T)this["Status"];
            set => this["Status"] = value;
        }

        /// <summary>
        /// json element with name 'msg', type is string.
        /// </summary>
        [JsonProperty("msg")]
        public string Message {
            get => this["Message"] as string;
            set => this["Message"] = value;
        }

        /// <summary>
        /// json element with name 'content', type is object.
        /// </summary>
        [JsonProperty("content")]
        public object Content {
            get => this["Content"];
            set => this["Content"] = value;
        }

    }

}
