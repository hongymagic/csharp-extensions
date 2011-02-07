namespace Extensions.Tests {
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for ArrayExtensionsUnitTest
    /// </summary>
    [TestClass]
    public class ArrayExtensionsUnitTest {
        public ArrayExtensionsUnitTest() {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void PushTest() {
            // Given
            var a = new[] { 1, 2, 3 };
            var b = new string[] {};

            // When
            ArrayExtensions.Push(ref a, 4);
            ArrayExtensions.Push(ref b, "Hello");

            // Then
            Assert.AreEqual(4, a.Length);
            Assert.AreEqual(4, a[3]);
            Assert.AreNotEqual(4, a[0]);

            Assert.AreEqual(1, b.Length);
            Assert.AreEqual("Hello", b[0]);
        }

        [TestMethod]
        public void PopTest() {
            // Given
            var a = new[] { 1, 2, 3 };
            var b = new[] { 1 };

            // When
            var A = ArrayExtensions.Pop(ref a);
            var B = ArrayExtensions.Pop(ref b);

            // Then
            Assert.AreEqual(2, a.Length);
            Assert.AreEqual(1, a[0]);
            Assert.AreEqual(3, A);

            Assert.AreEqual(0, b.Length);
            Assert.AreEqual(1, B);
        }

        [TestMethod]
        public void ShiftTest() {
            // Given
            var a = new[] { 1, 2, 3 };
            var b = new[] { 1 };

            // When
            var A = ArrayExtensions.Shift(ref a);
            var B = ArrayExtensions.Shift(ref b);

            // Then
            Assert.AreEqual(2, a.Length);
            Assert.AreEqual(2, a[0]);
            Assert.AreEqual(1, A);

            Assert.AreEqual(0, b.Length);
            Assert.AreEqual(1, B);
        }

        [TestMethod]
        public void FilterTest() {
            // Given
            var a = new[] { null, "", "David", "Hong" };

            // When we collect non-null/empty strings
            var b = a.Filter(x => !string.IsNullOrEmpty(x));

            // Then
            Assert.AreEqual(4, a.Length);
            Assert.AreEqual(2, b.Length);
            Assert.AreEqual("David", b[0]);
        }

        [TestMethod]
        public void MapTest() {
            // Given
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // When
            var b = a.Map(x => x.ToString());
            var c = a.Map(x => System.Math.Sqrt(x));

            // Then
            Assert.AreEqual(b.Length, a.Length);
            Assert.AreEqual(c.Length, a.Length);
            Assert.AreEqual("1", b[0]);
            Assert.AreEqual(3, c[c.Length - 1]);
        }

        [TestMethod]
        public void JoinTest() {
            // Given
            var a = new[] {"Alpha", "Beta", "Theta"};

            // When
            var s = a.Join("&");

            // Then
            Assert.AreEqual("Alpha&Beta&Theta", s);
        }
    }
}
