using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public FixedJoystick joystick;
    public float moveSpeed;

    float hInput, vInput;

    int score  =    0;
    public GameObject winText;
    public int winScore;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        hInput = joystick.Horizontal;
        vInput = joystick.Vertical;

        transform.Translate(hInput, vInput, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Carrot")
        {
            score++;
            Destroy(collision.gameObject);
            if (score >= winScore)
            {
                winText.SetActive(true);
            }
        }
    }
}
