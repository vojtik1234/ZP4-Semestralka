using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float highestY; // Promìnná pro uchování nejvyšší dosažené výšky kamery

    // Start is called before the first frame update
    void Start()
    {
        highestY = transform.position.y; // Nastavte poèáteèní nejvyšší výšku na aktuální pozici kamery
        UpdateScoreText(); // Aktualizujte text skóre
    }

    // Update is called once per frame
    void Update()
    {
        // Zjistìte aktuální pozici kamery
        float currentY = transform.position.y;

        // Pokud aktuální pozice kamery je vyšší než nejvyšší dosažená výška, aktualizujte nejvyšší výšku
        if (currentY > highestY)
        {
            highestY = currentY;
            UpdateScoreText(); // Aktualizujte text skóre
        }
    }

    // Metoda pro aktualizaci textu skóre
    void UpdateScoreText()
    {
        // Zobrazte nejvyšší dosaženou výšku jako skóre
        scoreText.text = "Skóre: " + Mathf.Round(highestY);
    }
}