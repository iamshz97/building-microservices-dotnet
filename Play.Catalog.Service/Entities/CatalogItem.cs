using Play.Common;
using System;

public class CatalogItem : IEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}