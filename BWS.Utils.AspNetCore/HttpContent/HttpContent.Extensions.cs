using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace BWS.Utils.AspNetCore.HttpContent {

    /// <summary>
    /// Some extension methods fot http content.
    /// </summary>
    public static class HttpContextExtensions {

        /// <summary>
        /// Try to insert a k-v pair into the Items.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetStringEntry(this HttpContext context, string key, string value) {
            context.Items.Add(key, value);
        }

        /// <summary>
        /// Try to get a value from Items by key, if not contained, return default(string).
        /// </summary>
        /// <param name="context"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void GetStringEntry(this HttpContext context, string key, out string value) {
            context.Items.TryGetValue(key, out var v);
            value = v as string;
        }

    }

}
