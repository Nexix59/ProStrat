using System.Collections.Generic;



public class ResourceManager
{
    private Kingdom owner;
    private Dictionary<ResourceType, int> resources;

    public ResourceManager(Kingdom owner)
    {
        this.owner = owner;
        resources = new Dictionary<ResourceType, int>();
        // Initialize resources with default values
        foreach (ResourceType resourceType in System.Enum.GetValues(typeof(ResourceType)))
        {
            resources[resourceType] = 0;
        }
    }

    

    
    public enum ResourceType
    {
        Gold,
        Food,
        Stone,
        Wood,
        Iron,
        Kush,
        //Add more as fucking needed
    }
    

}