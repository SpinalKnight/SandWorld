using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform Player;
    public float enemySpeed = 1f;

    bool spinning = true;

    private int frame;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        frame++;


        rb.velocity = new Vector2(enemySpeed, rb.velocity.y);

        if (frame >= 200 && enemySpeed <= 5f)
        {
            enemySpeed += 0.2f;
            frame = 0;
        }

        if (spinning)
        {
            transform.Rotate(0, 0, rb.velocity.x * -5 * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        print(other.gameObject.tag);
        if (other.gameObject.CompareTag("StopSpinning"))
        {

            spinning = false;
        }
    }
   
}
