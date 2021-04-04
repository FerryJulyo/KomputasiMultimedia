using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text brainText;
    private bool carryingBrain = false;
    void Start()
    {
        UpdateBrainText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Brain"))
        {
            carryingBrain = true;
            UpdateBrainText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateBrainText()
    {
        string brainMessage = "Tidak Makan Otak :-(";
        if (carryingBrain) brainMessage = "Makan Otak :-)";
        brainText.text = brainMessage;
    }
}