using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scorecounter : MonoBehaviour
{
    [Header("Dynamic")]                                                          // b
    public int points = 0;

    private TextMeshProGUI Score;                                                        // c

    void Start()
    {
        points = GetComponent<Score>;                                           // d
    }

    void Update()
    {
        Score.text = points.ToString("#,0"); // This 0 is a zero!              // e
    }
}