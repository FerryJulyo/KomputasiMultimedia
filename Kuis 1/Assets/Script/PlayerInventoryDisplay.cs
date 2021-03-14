using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] jiwaPlaceholders;
    public Sprite iconJiwaA;
    public Sprite iconJiwaB;
    public void OnChangeJiwaTotal(int jiwaTotal)
    {
        for (int i = 0; i < jiwaPlaceholders.Length; ++i)
        {
            if (i < jiwaTotal)
                jiwaPlaceholders[i].sprite = iconJiwaA;
            else
                jiwaPlaceholders[i].sprite = iconJiwaB;
        }
    }
}