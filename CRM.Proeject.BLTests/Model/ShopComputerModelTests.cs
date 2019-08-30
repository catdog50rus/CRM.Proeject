using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM.Proeject.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Proeject.BL.Model.Tests
{
    [TestClass()]
    public class ShopComputerModelTests
    {
        [TestMethod()]
        public void StartTest()
        {
            var model = new ShopComputerModel();
            model.Start();
        }
    }
}