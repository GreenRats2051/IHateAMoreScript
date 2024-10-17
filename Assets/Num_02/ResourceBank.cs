using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Resource;

public class ResourceBank : MonoBehaviour
{
    private Dictionary<ResourceType, Resource> _resource;

    public ResourceBank()
    {

    }

    void InitResources()
    {
        _resource = new();
        for(int i = 0; i < Enum.GetValues(typeof(ResourceType)).Length; i++)
        {
            //Resource newResource = new((ResourceType)i)
        }
    }
}
