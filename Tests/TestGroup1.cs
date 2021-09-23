using Effort.Provider;
using Example;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public abstract class BaseUnitTest
    {

        public const int TEST_ITERATION_COUNT = 100;
        protected EffortConnection connection;
        protected MyDB dbContext;
        protected void SeedData()
        {
            
            dbContext.Bars.AddRange(Enumerable.Range(0, 100).Select(x => new Bar { ID = Guid.NewGuid() }));
            dbContext.Bazs.AddRange(Enumerable.Range(0, 100).Select(x => new Baz { ID = Guid.NewGuid() }));
            dbContext.Corges.AddRange(Enumerable.Range(0, 100).Select(x => new Corge { ID = Guid.NewGuid() }));
            dbContext.Foos.AddRange(Enumerable.Range(0, 100).Select(x => new Foo { ID = Guid.NewGuid() }));
            dbContext.Freds.AddRange(Enumerable.Range(0, 100).Select(x => new Fred { ID = Guid.NewGuid() }));
            dbContext.Garplies.AddRange(Enumerable.Range(0, 100).Select(x => new Garply { ID = Guid.NewGuid() }));
            dbContext.Graults.AddRange(Enumerable.Range(0, 100).Select(x => new Grault { ID = Guid.NewGuid() }));
            dbContext.Plughs.AddRange(Enumerable.Range(0, 100).Select(x => new Plugh { ID = Guid.NewGuid() }));
            dbContext.Quuxii.AddRange(Enumerable.Range(0, 100).Select(x => new Quux { ID = Guid.NewGuid() }));
            dbContext.Quxii.AddRange(Enumerable.Range(0, 100).Select(x => new Qux { ID = Guid.NewGuid() }));
            dbContext.Thuds.AddRange(Enumerable.Range(0, 100).Select(x => new Thud { ID = Guid.NewGuid() }));
            dbContext.Waldos.AddRange(Enumerable.Range(0, 100).Select(x => new Waldo { ID = Guid.NewGuid() }));
            dbContext.Xyzzies.AddRange(Enumerable.Range(0, 100).Select(x => new Xyzzy { ID = Guid.NewGuid() }));            


            dbContext.SaveChanges();
        }

        
    }

    [TestClass]
    public class Domain1 : BaseUnitTest
    {

        private static IEnumerable<object[]> GetData() => Enumerable.Range(0, TEST_ITERATION_COUNT).Select(x => new object[] { Guid.NewGuid() });

        [TestInitialize]
        public void SetUp()
        {
            connection = Effort.DbConnectionFactory.CreateTransient();
            dbContext = new MyDB(connection, true);
            SeedData();
            
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G1T1(Guid id)
        {
            Assert.IsTrue(2 + 2 == 4);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G1T2(Guid id)
        {
            Assert.IsTrue(2 + 1 == 3);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G1T3(Guid id)
        {
            Assert.IsTrue(2 + 3 == 5);
        }
    }

    [TestClass]
    public class Domain2 : BaseUnitTest
    {

        private static IEnumerable<object[]> GetData() => Enumerable.Range(0, TEST_ITERATION_COUNT).Select(x => new object[] { Guid.NewGuid() });

        [TestInitialize]
        public void SetUp()
        {
            connection = Effort.DbConnectionFactory.CreateTransient();
            dbContext = new MyDB(connection, true);
            SeedData();

        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G2T1(Guid id)
        {
            Assert.IsTrue(2 + 2 == 4);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G2T2(Guid id)
        {
            Assert.IsTrue(2 + 1 == 3);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G2T3(Guid id)
        {
            Assert.IsTrue(2 + 3 == 5);
        }
    }

    [TestClass]
    public class Domain3 : BaseUnitTest
    {

        private static IEnumerable<object[]> GetData() => Enumerable.Range(0, TEST_ITERATION_COUNT).Select(x => new object[] { Guid.NewGuid() });

        [TestInitialize]
        public void SetUp()
        {
            connection = Effort.DbConnectionFactory.CreateTransient();
            dbContext = new MyDB(connection, true);
            SeedData();

        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G3T1(Guid id)
        {
            Assert.IsTrue(2 + 2 == 4);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G3T2(Guid id)
        {
            Assert.IsTrue(2 + 1 == 3);
        }

        [DataTestMethod]
        [DynamicData(nameof(GetData), DynamicDataSourceType.Method)]
        public void G3T3(Guid id)
        {
            Assert.IsTrue(2 + 3 == 5);
        }
    }
}
