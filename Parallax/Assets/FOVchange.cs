using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVchange : MonoBehaviour
{
    public Camera camera;
    public Transform player;
    private int frame = 100;

    void Start()
    {
        camera.orthographicSize = 7;
    }

    void Update()
    {
        frame++;

        if (player.position.x > 187)
        {
            frame = 0;
        }

        if(frame == 5)
        {
            camera.orthographicSize = 8;
        }
        else if (frame == 10)
        {
            camera.orthographicSize = 9;
        }
        else if (frame == 15)
        {
            camera.orthographicSize = 10;
        }
        else if (frame == 20)
        {
            camera.orthographicSize = 11;
        }
        else if (frame == 25)
        {
            camera.orthographicSize = 12;
        }
        else if (frame == 30)
        {
            camera.orthographicSize = 13;
        }
        else if (frame == 35)
        {
            camera.orthographicSize = 14;
        }
        else if (frame == 40)
        {
            camera.orthographicSize = 15;
        }
    }
}
