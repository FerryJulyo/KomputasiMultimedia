using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text brainText;
    private int totalBrains = 0;
    void Start()
    {
        UpdateBrainText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Brain"))
        {
            totalBrains++;
            UpdateBrainText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateBrainText()
    {
        string brainMessage = "Brains = " + totalBrains;
        brainText.text = brainMessage;
    }
}