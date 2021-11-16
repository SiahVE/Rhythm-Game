using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public NoteScroller theNS;
    public bool startPlaying;
    public static GameManager instance;
    public int currentMultiplier;
    public int multiplierTracker;
    public int currentScore;
    public int scorePerNote = 100;
    public Text scoreText;
    public Text multiText;
    public int[] multiplierThreshold;

    void Start()
    {
        instance = this;
        scoreText.text = "Score: 0";
        currentMultiplier = 1;
    }

    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theNS.hasStarted = true;
                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Note Hit");

        if (currentMultiplier - 1 < multiplierThreshold.Length)
        {
            multiplierTracker++;

            if (multiplierThreshold[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
        multiText.text = "Multiplier: x" + currentMultiplier;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");
        SceneManager.LoadScene("MainScene");
    }
}
