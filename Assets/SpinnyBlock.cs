using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyBlock : MonoBehaviour
{
    [SerializeField] float SpinRate;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, SpinRate * Time.deltaTime);
    }
}
