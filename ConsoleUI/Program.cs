using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//Data Tranformation Object = DTO
ProductTest();

//CategoryTest();


static void ProductTest()
{
    ProductManager productManager = new(new EfProductDal());
    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + " / " + product.CategoryName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine($"{category.CategoryName} = {category.CategoryId}");
    }
}