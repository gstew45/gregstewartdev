using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Unit.Tests.Mappings
{
    [TestClass]
    public class MappingTests
    {
        private IConfigurationProvider _configuration;
        private IMapper _mapper;

        [TestInitialize]
        public void Setup()
        {
            MappingTestsFixture mappingTestsFixture = new MappingTestsFixture();
            _configuration = mappingTestsFixture.ConfigurationProvider;
            _mapper = mappingTestsFixture.Mapper;
        }

        [TestMethod]
        public void ShouldHaveValidConfiguration()
        {
            _configuration.AssertConfigurationIsValid();
        }

        ////[TestMethod]
        ////public void ShouldMapCategoryToCategoryDto()
        ////{
        ////    var entity = new Category();

        ////    var result = _mapper.Map<CategoryDto>(entity);

        ////    result.ShouldNotBeNull();
        ////    result.ShouldBeOfType<CategoryDto>();
        ////}

        ////[TestMethod]
        ////public void ShouldMapCustomerToCustomerLookupDto()
        ////{
        ////    var entity = new Customer();

        ////    var result = _mapper.Map<CustomerLookupDto>(entity);

        ////    result.ShouldNotBeNull();
        ////    result.ShouldBeOfType<CustomerLookupDto>();
        ////}
    }
}
