namespace TemplateMethod
{
    public class TemplateMethodMain
    {
        static void Main()
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

        }
    }
}
