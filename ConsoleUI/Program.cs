using Business.Concrete;
using DataAccess.Concrete.InMemory;

ProductManager productManager = new(new InMemoryProductDal());
foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}