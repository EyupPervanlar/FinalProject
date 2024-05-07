using Business;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        ProductTest();

        //CategoryTest();
        Console.ReadKey();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        var result = productManager.GetProductDetails();
        if (result.Success==true) 
        {
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName+" / "+product.CategoryName);
            }
        }
        foreach (var product in productManager.GetProductDetails().Data)
        {
            Console.WriteLine(product.ProductName+"/"+product.CategoryName);
        }
    }
}