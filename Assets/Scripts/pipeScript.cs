using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    public Vector2 startPos;
    public float endPos;
    public float maxOffset;
    private float hightOffset;

    void Start()
    {
        hightOffset = getRandomPoint();
    }

    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.x < endPos)
        {
            Vector3 newPos = pos;
            newPos.x = startPos.x;
            hightOffset = getRandomPoint();
            newPos.y = startPos.y + hightOffset;
            transform.position = newPos;
        }
    }

    float getRandomPoint()
    {
        return Random.Range(maxOffset * -1, maxOffset);
    }
}
