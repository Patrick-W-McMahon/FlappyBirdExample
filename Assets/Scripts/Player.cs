using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool playerAlive = true;
    public List<Sprite> sprites;
    private int score;
    public Text scoreBoard;
    public List<GameObject> pointTriggers;
    private Rigidbody2D rb;
    [SerializeField]
    public float jumpPower;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        setScoreboard(score);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && playerAlive)
        {
            rb.velocity = new Vector2(0, jumpPower);
        }
        if(playerAlive==false)
        {
            rb.velocity = new Vector2(0, jumpPower * -1);
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision"+ other.gameObject.tag);
        if (other.name == "player")
        {
            score++;
            setScoreboard(score);
        }
    }

    public void kill()
    {
        //Debug.Log("player death");
        playerAlive = false;
    }

    void setScoreboard(int v)
    {
        scoreBoard.text = v.ToString();
    }
}
