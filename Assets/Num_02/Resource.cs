public class Resource
{
    public int ResourceAmount { get; private set; }
    public enum ResourceType { Wood, Stone, Gold, Food }
    public ResourceType _resourceType { get; set; }
    public Resource(ResourceType type, int amount)
    {
        _resourceType = type;
        ResourceAmount = amount;
    }

    public void AddResource(int amount)
    {
        ResourceAmount += amount;
    }
}
