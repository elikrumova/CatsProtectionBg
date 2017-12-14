namespace CatsProtectionBg.Web.Models.Orders
{
    using Common.Mapping;
    using Data.Models;

    public class CharityItemListingOrdersModel : IMapFrom<CharityItem>
    {
       public int Id { get; set; }

       public string Name { get; set; }

       public decimal Price { get; set; }

       public  string Description { get; set; }

       public string Imageurl { get; set; }

       public int Quantity { get; set; }
        
    }
}
