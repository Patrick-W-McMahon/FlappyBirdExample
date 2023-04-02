using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private LevelManager levelManager;
    
    void Start()
    {
        levelManager = FindObjectsOfType<LevelManager>()[0];
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            levelManager.killPlayer();
        }
    }
}
