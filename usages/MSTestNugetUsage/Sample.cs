﻿[TestClass]
public partial class Sample
{
    [TestMethod]
    public Task Test() =>
        Verify("value");
}