# BWS.Utils.AspNetCore
![](icon.jpg)

A extensions and helper for asp.net core 2.0

## Travis CI (latest)
 [![Build Status](https://travis-ci.org/ws-dotnet-core/BWS.Utils.AspNetCore.svg?branch=master)](https://travis-ci.org/ws-dotnet-core/BWS.Utils.AspNetCore)

## API List

### BWS.Utils.AspNetCore.Controllers
1. extension method Microsoft.AspNetCore.Mvc.JsonResult JsonFormat(this Controller c, dynamic model)
2. extension method IEnumerable<string> GetModelErrors(this Controller c)
3. extension method string GetErrorMessage(this Controller c, bool succeed = true, string msg = "")

### BWS.Utils.AspNetCore.JsonResult
1.  JsonBase<T> : Dictionary<string, object> where T : struct
