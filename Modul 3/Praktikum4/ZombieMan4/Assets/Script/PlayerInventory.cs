using UnityEngine;
using System.Collections;
public class PlayerInventory : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private bool carryingBrain = false;
    void Start()
    {
        playerInventoryDisplay = GetComponent<
        PlayerInventoryDisplay>();
        playerInventoryDisplay.OnChangeCarryingBrain(carryingBrain);
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Brain"))
        {
            carryingBrain = true;

            playerInventoryDisplay.OnChangeCarryingBrain(carryingBrain);
            Destroy(hit.gameObject);
        }
    }
}