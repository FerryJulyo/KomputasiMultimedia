using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] brainPlaceholders;
    public Sprite iconBrainA;
    public Sprite iconBrainB;
    public void OnChangeBrainTotal(int brainTotal)
    {
        for (int i = 0; i < brainPlaceholders.Length; ++i)
        {
            if (i < brainTotal)
                brainPlaceholders[i].sprite = iconBrainA;
            else
                brainPlaceholders[i].sprite = iconBrainB;
        }
    }
}