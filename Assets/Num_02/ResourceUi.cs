using UnityEngine;
using static Resource;
using UnityEngine.UI;
using System;
using System.Resources;

public class ResourceUi : MonoBehaviour
{
    public InputField amountInput;
    public Dropdown dropdown;
    public Button addButton;

    private void Start()
    {
        addButton.onClick.AddListener(OnAddButtonClicked);
        dropdown.ClearOptions();
        foreach (ResourceType type in System.Enum.GetValues(typeof(ResourceType)))
        {
            dropdown.options.Add(new Dropdown.OptionData(type.ToString()));
        }
        dropdown.RefreshShownValue();
        addButton.onClick.AddListener(OnAddButtonClicked);
        Debug.Log("Wood: " + ResourceBank.Instance.GetResourceAmount(ResourceType.Wood));
        Debug.Log("Stone: " + ResourceBank.Instance.GetResourceAmount(ResourceType.Stone));
        Debug.Log("Gold: " + ResourceBank.Instance.GetResourceAmount(ResourceType.Gold));
        Debug.Log("Food: " + ResourceBank.Instance.GetResourceAmount(ResourceType.Food));
    }

    public void OnAddButtonClicked()
    {
        int amount = Convert.ToInt32(amountInput.text);
        Debug.Log(amount);
        ResourceType type = (ResourceType)dropdown.value;
        ResourceBank.Instance.AddResource(type, amount);
        Debug.Log(ResourceBank.Instance.resources[type].ResourceAmount);
    }
}
