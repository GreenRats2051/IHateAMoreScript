using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public int ResourceAmount { get; set; }
    public enum ResourceType { wood, stone, Gold }
    public ResourceType _resourceType { get; set; }
}
