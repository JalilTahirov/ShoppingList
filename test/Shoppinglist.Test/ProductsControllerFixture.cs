using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shoppinglist.API.Controllers;
using Shoppinglist.API.Services;
using System.Threading.Tasks;

namespace Shoppinglist.Test
{
    [TestClass]
    public class ProductsControllerFixture
    {
        [TestInitialize]
        public void OnTestInitialize()
        {
            _SystemUnderTest = null;
        }

        private ProductsController _SystemUnderTest;
        public ProductsController SystemUnderTest
        {
            get
            {
                if (_SystemUnderTest == null)
                {
                    _SystemUnderTest = new ProductsController(new ProductService(), null);
                }

                return _SystemUnderTest;
            }
        }


        [TestMethod]
        public async void ProductsController_GetAllAsync_ModelIsNotNull()
        {
            var actual = await SystemUnderTest.GetAllAsync();
            //    UnitTestUtility.GetModel<CalculatorViewModel>(
            //        SystemUnderTest.Index());

            Assert.IsNotNull(actual, "Model was null.");
        }

        [TestMethod]
        public void TestMethod1()
        {
            // arrange


            // act


            // assert
        }


    }
}
