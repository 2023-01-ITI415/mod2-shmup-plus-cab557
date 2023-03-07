using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scorecounter : MonoBehaviour
{
    [Header("Dynamic")]                                                          // b
    public static int points = 0;

    private TextMeshProUGUI Score;                                                        // c

    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();                                           // d
    }

    void Update()
    {
        Score.text = points.ToString("#,0"); // This 0 is a zero!              // e
    }
}