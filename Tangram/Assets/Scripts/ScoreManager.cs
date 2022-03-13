using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
public static ScoreManager instance;

public Text ScoreText;
public Text HighscoreText;

int score = 0;
int highscore = 0;

void Awake() {
instance = this;
}

void start () {
        highscore = PlayerPrefs.GetInt("highscore", 0);
ScoreText.text = score.ToString() + " POINTS";
HighscoreText.text = "HIGHSCORE: " + highscore.ToString();

}

public void AddPoint() {
    score += 10;
        ScoreText.text = score.ToString() + " POINTS";
        HighscoreText.text = "HIGHSCORE: " + score.ToString();

        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score); 

        }


    }



}
