using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMP_Text>().SetText($"{FindObjectOfType<Player>().GetScore()}\n{FindObjectOfType<Player>().GetHighScore()}");
    }
}
