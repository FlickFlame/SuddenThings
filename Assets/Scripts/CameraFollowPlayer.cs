using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    public Transform player;
    private Vector3 Cam;

    void Update()
    {
        if (player != null) {
            transform.position = new Vector3(player.position.x,player.position.y, -10);
        }
    }
}
