using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticResetBG : MonoBehaviour
{
    public float startPos;

    void Update()
    {
        if (!GetComponent<Renderer>().isVisible && transform.position.x < 2 && Time.frameCount > 2)
        {
            Debug.Log("reset");
            Vector3 pos = transform.position;
            pos.x = startPos;
            transform.position = pos;
        }
    }
}