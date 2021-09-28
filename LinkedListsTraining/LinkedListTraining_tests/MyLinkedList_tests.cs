using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void AddAtHead_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtTail(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_ThreeNumbers_CanReturnNumber()
        {
            int[] input = { 2, 3, 4 };
            int[] expected = { 2, 3, 4 };
            var sut = new MyLinkedList();

            sut.AddAtTail(input[0]);
            sut.AddAtTail(input[1]);
            sut.AddAtTail(input[2]);

            for (int i = 0; i < expected.Length; i++)
            {
                var actual = sut.Get(i);
                Assert.AreEqual(expected[i], actual);
            }
        }

        [TestMethod]
        public void AddAtIndex_OneNumber_CanReturnNumber()
        {
            var input = 2;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(3);
            sut.AddAtHead(1);
            sut.AddAtIndex(1, input);

            var actual = sut.Get(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_ThreeNumbers_CanReturnNumber()
        {
            int[] input = { 2, 3, 4 };
            var expected = 4;
            var sut = new MyLinkedList();

            sut.AddAtHead(input[2]);
            sut.AddAtHead(input[1]);
            sut.AddAtHead(input[0]);
            sut.DeleteAtIndex(1);

            var actual = sut.Get(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtHeadTailIndex_Get_DeleteIndex_CanReturnNumber()
        {
            int[] input = { 1, 3, 2 };
            int[] expected = { 2, 2};
            var sut = new MyLinkedList();

            sut.AddAtHead(input[0]);
            sut.AddAtTail(input[1]);
            sut.AddAtIndex(1, input[2]);
            var actual = sut.Get(1);
            Assert.AreEqual(expected[0], actual);
            sut.DeleteAtIndex(0);

            actual = sut.Get(0);
            Assert.AreEqual(expected[1], actual);
        }
    }
}
