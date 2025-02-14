﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//Data Tranformation Object = DTO
ProductTest();

//CategoryTest();


static void ProductTest()
{
    ProductManager productManager = new(new EfProductDal()
        ,new CategoryManager(new EfCategoryDal()));

    var result = productManager.GetProductDetails();

    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " / " + product.CategoryName);
        }
    }
    else 
    {
        Console.WriteLine(result.Message);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine($"{category.CategoryName} = {category.CategoryId}");
    }
}