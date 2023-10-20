using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShustovTS.Sprint3.Task3.V7.Lib;
namespace Tyuiu.ShustovTS.Sprint3.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';
            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "4ft h44t nt4";
            Assert.AreEqual(wait, res);
        }
    }
}
