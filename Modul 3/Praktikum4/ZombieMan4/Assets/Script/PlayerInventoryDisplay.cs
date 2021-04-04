using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text brainText;
    public void OnChangeCarryingBrain(bool carryingBrain)
    {
        string brainMessage = "Tidak Makan Otak :-(";
        if (carryingBrain) brainMessage = "Makan Otak :-)";
        brainText.text = brainMessage;
    }
}