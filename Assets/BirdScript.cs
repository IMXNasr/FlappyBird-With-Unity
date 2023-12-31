using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flapStrength;
    public LogicScript logic;
    public bool isAlive = true;
    public AudioSource flapSound;
    public AudioSource hitSound;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive) {
            myRigidbody2D.velocity = Vector2.up * flapStrength;
            flapSound.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(isAlive) {
            hitSound.Play();
            isAlive = false;
            logic.GameOver();
        }
    }
}
