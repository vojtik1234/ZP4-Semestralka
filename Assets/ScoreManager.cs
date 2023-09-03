using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float highestY; // Prom�nn� pro uchov�n� nejvy��� dosa�en� v��ky kamery

    // Start is called before the first frame update
    void Start()
    {
        highestY = transform.position.y; // Nastavte po��te�n� nejvy��� v��ku na aktu�ln� pozici kamery
        UpdateScoreText(); // Aktualizujte text sk�re
    }

    // Update is called once per frame
    void Update()
    {
        // Zjist�te aktu�ln� pozici kamery
        float currentY = transform.position.y;

        // Pokud aktu�ln� pozice kamery je vy��� ne� nejvy��� dosa�en� v��ka, aktualizujte nejvy��� v��ku
        if (currentY > highestY)
        {
            highestY = currentY;
            UpdateScoreText(); // Aktualizujte text sk�re
        }
    }

    // Metoda pro aktualizaci textu sk�re
    void UpdateScoreText()
    {
        // Zobrazte nejvy��� dosa�enou v��ku jako sk�re
        scoreText.text = "Sk�re: " + Mathf.Round(highestY);
    }
}