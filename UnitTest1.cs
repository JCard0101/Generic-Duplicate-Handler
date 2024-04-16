using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
       
        [Test]
        public void TestRemoveDuplicates_String()
        {

            var handlerString = new DuplicateHandler<string>();
            var newListString = new List<string> {"Hello","World","Hello","Hello"};

            var expected = new List<string> { "Hello", "World" };
            var actual = handlerString.RemoveDuplicates(newListString);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void TestRemoveDuplicates_Int()
        {

            var handlerInt = new DuplicateHandler<int>();
            var newListInt = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 3 };

            var expected = new List<int> { 1, 2, 3, 4, 5 };
            var actual = handlerInt.RemoveDuplicates(newListInt);

            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void TestRemoveDuplicates_Page()
        {

            var handlerFile = new DuplicateHandler<Page>();
            var newPage = new Page {Id = 1, FileName = "TestFile.txt", DocumentType = "TestDocType", ImportDate = DateTime.Now, PageNumber = 1};

            var newListObj = new List<Page> { newPage, newPage, newPage };

            var expected = new List<Page> { newPage };
            var actual = handlerFile.RemoveDuplicates(newListObj);

            Assert.That(actual, Is.EqualTo(expected));

        }

        public class DuplicateHandler<T>
        {
            public ICollection<T> RemoveDuplicates(ICollection<T> itemListCollection)
            {
                return itemListCollection.Distinct().ToList();
            }
        }
    }
}