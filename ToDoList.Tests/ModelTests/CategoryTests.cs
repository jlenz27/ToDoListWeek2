using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
    [TestClass]
    public class CategoryTests : IDisposable
    {
        public void Dispose()
        {
            Category.ClearAll();
        }
        [TestMethod]
        public void CategoryConstructor_CreatesInstanceOfCategory_Category()
        {
            Category newCategory = new Category("test category");
            Assert.AreEqual(typeof(Category), newCategory.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {

            string name = "Test Category";
            Category newCategory = new Category(name);
            string result = newCategory.Name;
            Assert.AreEqual(name, result);
        }
        [TestMethod]
        public void GetId_ReturnsCategoryId_Intt()
        {
            string name = "Test Category";
            Category newCategory = new Category(name);
            int result = newCategory.Id;
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void GetAll_ReturnsAllCategoryObjects_CategoryList()
        {
            //Arrange
            string name01 = "Work";
            string name02 = "School";
            Category newCategory1 = new Category(name01);
            Category newCategory2 = new Category(name02);
            List<Category> newList = new List<Category> { newCategory1, newCategory2 };

            //Act
            List<Category> result = Category.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }

    }
}