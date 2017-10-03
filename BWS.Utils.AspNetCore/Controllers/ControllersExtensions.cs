using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Linq;
using BWS.Utils.NetCore.Seriailzation.ContractResolvers;

namespace BWS.Utils.AspNetCore.Controllers {

    /// <summary>
    /// Asp.Net Core Controller Extensions.
    /// </summary>
    public static class ControllersExtensions {

        /// <summary>
        /// return a json result in format name style 'name_style' .
        /// </summary>
        /// <param name="c"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static JsonResult JsonFormat(this Controller c, dynamic model)
            => c.Json(model,
                new JsonSerializerSettings {
                    ContractResolver = new LowercaseContractResolver(),
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Formatting = Formatting.Indented
                });

        /// <summary>
        /// Read errors in model state.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetModelErrors(this Controller c)
            => c.ModelState.Values.Select(i => i.Errors.Select(s => s.ErrorMessage).FirstOrDefault());

        /// <summary>
        /// Return errors if not nullable, er return 'success'.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="succeed"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static string GetErrorMessage(this Controller c, bool succeed = true, string msg = "")
            => succeed ? "success" : msg;
    }

}
