using System;
using Xunit;
using BWS.Utils.AspNetCore.JsonResult;
using Newtonsoft.Json;

namespace JsonBase_TEST  {

    enum TestEnum { A, B }

    public class UnitTest1 {
        [Fact]
        public void JsonBaseSeriailize_TEST() {

            var jbase = new JsonBase<TestEnum> {
                Status = TestEnum.A,
                Message = "aaa",
                Content = "bbb"
            };
            var json = JsonConvert.SerializeObject(jbase);

            Assert.Equal("{\"status\":0,\"msg\":\"aaa\",\"content\":\"bbb\"}", json);

            var jbase2 = new JsonBase<TestEnum> {
                Status = TestEnum.A,
                Message = "aaa"
            };
            var json2 = JsonConvert.SerializeObject(jbase2);

            Assert.Equal("{\"status\":0,\"msg\":\"aaa\"}", json2);

        }
    }
}
