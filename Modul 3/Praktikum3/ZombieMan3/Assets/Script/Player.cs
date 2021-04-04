using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Image brainImage;
    public Sprite iconBrain;
    public Sprite iconNoBrain;
    private bool carryingBrain = false;
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Brain"))
        {
            carryingBrain = true;
            UpdateBrainImage();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateBrainImage()
    {
        if (carryingBrain)
            brainImage.sprite = iconBrain;
        else
            brainImage.sprite = iconNoBrain;
    }
}