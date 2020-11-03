using UnityEngine;
using TMPro;

public enum SystemType {Money = 0, Build}

public class SystemTextViewer : MonoBehaviour
{
    private TextMeshProUGUI textSystem;
    private TMPAlpha tmpAlpha;

    private void Awake()
    {
        textSystem = GetComponent<TextMeshProUGUI>();
        tmpAlpha = GetComponent<TMPAlpha>();
    }

    public void PrintText(SystemType type)
    {
        switch(type)
        {
            case SystemType.Money:
                textSystem.text = "System : Not enough gold";
                break;
            case SystemType.Build:
                textSystem.text = "System : Invalid space to build tower";
                break;
        }

        tmpAlpha.FadeOut();
    }
}
