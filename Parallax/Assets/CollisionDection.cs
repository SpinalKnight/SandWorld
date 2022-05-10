using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.tag);
        if(other.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
