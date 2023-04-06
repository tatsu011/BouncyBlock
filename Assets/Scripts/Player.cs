using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int Score = 0;
    [SerializeField] static int HighScore = 0;

    [SerializeField] Vector2 jumpVelocity = Vector2.up;
    [SerializeField] float jumpStrength = 2;
    int Scoretick = 0;
    int IncreaseScore = 30;

    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody2D>().velocity = jumpVelocity * jumpStrength;
        }
    }

    public int GetScore()
    {
        return Score;
    }
    public int GetHighScore()
    {
        return HighScore;
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", HighScore);
    }

    private void FixedUpdate()
    {
        Scoretick++;
        if (Scoretick == IncreaseScore)
        {
            Score++;
            Scoretick = 0;
        }
        if(Score > HighScore)
        {
            HighScore = Score;
        }
    }
}
