﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            // Arange
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";
            currentProduct.ProductId = 1;
            currentProduct.Description = "15-inch steel blade hand saw";
            currentProduct.ProductVendor.CompanyName = "ABC Corp";
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            // Act
            var actual = currentProduct.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
            // Rightclick to Run
        }
        [TestMethod()]
        public void SayHello_ParameterizedConstructorTest()
        {
            // Arange
            var currentProduct = new Product(1, "Saw", "15-inch steel blade hand saw");
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            // Act
            var actual = currentProduct.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
            // Rightclick to Run
        }
        [TestMethod()]
        public void SayHello_ObjectInitializer()
        {
            // Arange
            var currentProduct = new Product() {
                ProductName = "Saw",
                ProductId = 1,
                Description = "15-inch steel blade hand saw",
            };
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            // Act
            var actual = currentProduct.SayHello();

            // Assert
            Assert.AreEqual(expected, actual);
            // Rightclick to Run
        }
        [TestMethod()]
        public void Product_Null()
        {
            // Arange
            Product currentProduct = null;
            var companyName = currentProduct?.ProductVendor?.CompanyName;
            string expected = null;

            // Act
            var actual = companyName;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}