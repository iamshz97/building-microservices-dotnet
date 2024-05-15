namespace Play.Catalog.Service;

public static class Extensions
{
    public static ItemDto AsDto(this InventoryItem item)
    {
        return new ItemDto(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
    }
}