using System;
using System.Collections.Generic;
using UnityEngine;
using static Resource;

public class ResourceBank
{
    public Resource resource;
    public static ResourceBank instance;
    public Dictionary<ResourceType, Resource> resources;
    private const int StartResoursValue = 0;
    public static ResourceBank Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ResourceBank();
            }
            return instance;
        }
    }

    private ResourceBank()
    {
        resources = new Dictionary<ResourceType, Resource>();
        InitializeResources();
    }

    private void InitializeResources()
    {
        for (int i = 0; i < Enum.GetValues(typeof(ResourceType)).Length; i++)
        {
            Resource newResource = new((ResourceType)i, StartResoursValue);
            resources.Add((ResourceType)i, newResource);
        }
    }

    public int GetResourceAmount(ResourceType type)
    {
        if (resources.ContainsKey(type))
        {
            return resources[type].ResourceAmount;
        }
        return 0;
    }

    public bool TryResourceAmount(ResourceType type, out int resourceAmount)
    {
        resourceAmount = 0;
        if (resources.ContainsKey(type))
        {
            resourceAmount = resources[type].ResourceAmount;
            return true;
        }
        return false;
    }

    public void AddResource(ResourceType type, int amount)
    {
        resources[type].AddResource(amount);
    }
}
