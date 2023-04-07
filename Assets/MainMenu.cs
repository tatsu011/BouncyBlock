using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_Text HighScoreText;
    [SerializeField] TMP_Text ResetButtonText;
    [SerializeField] Button ResetButton;

    int ResetButtonState = 0;

    // Start is called before the first frame update
    void Start()
    {
        int HighScore = PlayerPrefs.GetInt("HighScore");

        HighScoreText.SetText($"HighScore: {HighScore}");

        if(HighScore == 0)
        {
            ResetButton.gameObject.SetActive(false);
        }
        Cursor.visible = true;
    }


    public void PlayButtonPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ResetButtonPressed()
    {
        if (ResetButtonState == 0)
        {
            ResetButtonText.SetText("Are you sure?");
            ResetButtonState = 1;
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", 0);
            ResetButton.gameObject.SetActive(false);
            HighScoreText.SetText($"HighScore: {0}");
        }
    }

    public void ExitbuttonPressed()
    {
        Application.Quit();
    }

}
