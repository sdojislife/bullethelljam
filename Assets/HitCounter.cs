using System;
using UnityEngine;
using TMPro;
public class HitCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private void Start()
    {
        if (PlayerHealth.CurrentHits == 0)
        {
            text.text = "Thank you for playing." + System.Environment.NewLine + "Hits taken: " + PlayerHealth.CurrentHits + System.Environment.NewLine + "YOU ARE AN INSANE LEGEND!";
        }
        else
        {
            text.text = "Thank you for playing." + System.Environment.NewLine + "Hits taken: " + PlayerHealth.CurrentHits;
        }
    }
}
