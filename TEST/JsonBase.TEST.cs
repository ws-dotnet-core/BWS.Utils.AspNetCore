using BWS.Utils.AspNetCore.JsonResult;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace TEST {
    [TestClass]
    public class JsonBase_TEST {

        enum TestEnum { A, B }

        [TestMethod]
        public void JsonBaseSeriailize_TEST() {

            var jbase = new JsonBase<TestEnum> {
                Status = TestEnum.A,
                Message = "aaa",
                Content = "bbb"
            };
            var json = JsonConvert.SerializeObject(jbase);

            Assert.AreEqual("{\"status\":0,\"msg\":\"aaa\",\"content\":\"bbb\"}", json);

        }

    }
}
