using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{

    public Text jiwaText;
    private PlayerInventoryDisplay playerInventoryDisplay;
    private int totalJiwa = 0;
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
        UpdateJiwaText();

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Jiwa"))
        {
            totalJiwa++;
            playerInventoryDisplay.OnChangeJiwaTotal(totalJiwa);
            UpdateJiwaText();
            Destroy(hit.gameObject);
        }


    }
    private void UpdateJiwaText()
    {
        string jiwaMessage = "Jiwa = " + totalJiwa;
        jiwaText.text = jiwaMessage;
    }

}
