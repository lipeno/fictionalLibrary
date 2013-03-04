using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DobrisaCesaric.DomainModel;
using DobrisaCesaric.DomainModel.Repositories;

namespace DobrisaCesaric.DomainTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class BookRepositoryTest
    {
        public BookRepositoryTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
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
        public void BookAddTest()
        {
            BookRepository bookRepo = BookRepository.GetInstance();

            //Author cashAcc = new CashAccount("Gotovina");
            Author author = new Author("Lao Tsu");
            List<Author> authorList = new List<Author>();
            authorList.Add(author);

            Book book = new Book(Guid.NewGuid(), "2534534534535353", authorList, "Tao Te Ching");

            bookRepo.AddBook(book);

            Assert.AreEqual(1, bookRepo.Count());

            Book book2 = bookRepo.GetBookByName("Tao Te Ching");

            Assert.IsInstanceOfType(book2, typeof(Book));
        }
    }
}
