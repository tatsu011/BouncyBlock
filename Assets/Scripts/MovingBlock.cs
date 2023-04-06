using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;

    float StartingYPos;
    [SerializeField] float variance = 2f;

    private void Start()
    {
        StartingYPos = transform.position.y;
        Vector3 NewPos = new Vector3(transform.position.x, StartingYPos + Random.Range(-variance, variance), transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if(transform.position.x <= -12f)
        {
            Reset();
        }
    }

    void Reset()
    {
        transform.position += Vector3.right * 30;
        Vector3 NewPos = new Vector3(transform.position.x, StartingYPos + Random.Range(-variance, variance), transform.position.z);
    }
}
