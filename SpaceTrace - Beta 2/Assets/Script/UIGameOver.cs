using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    // Script untuk menampilkan score dari method GetScore()
   [SerializeField] TextMeshProUGUI scoreText;
   ScoreKeeper scoreKeeper;
   
   void Awake()
   {
       scoreKeeper =FindObjectOfType<ScoreKeeper>();
   }

   void Start()
   {
       scoreText.text = "   Score:\n" + scoreKeeper.GetScore();

   }
}
