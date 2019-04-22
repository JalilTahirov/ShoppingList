using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shoppinglist.API.Controllers;
using Shoppinglist.API.Domain.Models;
using Shoppinglist.API.Domain.Services.Communication;
using Shoppinglist.API.Services;
using System.Threading.Tasks;

namespace Shoppinglist.Test
{
    [TestClass]
    public class ProductsControllerFixtureUsingMocks
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


        private MockProductService _ProductServiceInstance;

        public Task<ProductResponse> DEFAULT_RETURN_VALUE = new ProductResponse( new Product() { Name = "Milk" });

        public MockProductService ProductServiceInstance
        {
            get
            {
                if (_ProductServiceInstance == null)
                {
                    _ProductServiceInstance = 
                        new MockProductService();

                    _ProductServiceInstance.ReturnValue =
                        Task<DEFAULT_RETURN_VALUE>;
                }

                return _ProductServiceInstance;
            }
        }

                      

        public MockCalculatorService CalculatorServiceInstance
        {
            get
            {
                if (_CalculatorServiceInstance == null)
                {
                    _CalculatorServiceInstance =
                        new MockCalculatorService();

                    _CalculatorServiceInstance.ReturnValue =
                        DEFAULT_RETURN_VALUE;
                }

                return _CalculatorServiceInstance;
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
