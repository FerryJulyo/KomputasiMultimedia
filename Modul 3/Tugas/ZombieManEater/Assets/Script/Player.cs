using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Image prymoImage;
    public Sprite iconPrymo;
    public Sprite iconNoPrymo;
    private bool carryingPrymo = false;
    public Text pieText;
    private int totalPie = 0;
    private PlayerInventoryDisplay playerInventoryDisplay;
    private int totalBrain = 0;
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
        UpdatePieText();

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Prymo"))
        {
            carryingPrymo = true;
            UpdatePrymoImage();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Pie"))
        {
            totalPie++;
            UpdatePieText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Brain"))
        {
            totalBrain++;
            playerInventoryDisplay.OnChangeBrainTotal(totalBrain);
            Destroy(hit.gameObject);
        }


    }
    private void UpdatePieText()
    {
        string pieMessage = "Pie = " + totalPie;
        pieText.text = pieMessage;
    }

    private void UpdatePrymoImage()
    {
        if (carryingPrymo)
            prymoImage.sprite = iconPrymo;
        else
            prymoImage.sprite = iconNoPrymo;
    }
}
