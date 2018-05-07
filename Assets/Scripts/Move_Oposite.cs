using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Oposite : MonoBehaviour
{

    // Earth’s rotation: Earth spins on its axis, one counterclockwise rotation every 24 hours.
    // Earth’s revolution: Earth goes around the sun, one counterclockwise revolution every 365 days.

    // following numbers are for looks-and-feels, have NO real meaning!
    private float rotSpeed = 0f;
    private float revSpeed = 4f;

    void Update()
    {
        float t = Time.time;
        float posX = transform.localPosition.x;
        float posZ = transform.localPosition.z;
        float posY = Mathf.Sin(revSpeed * t*2);
        gameObject.transform.position = new Vector3(posX, posY, posZ);
        float rotY = revSpeed * t;
        // gameObject.transform.localRotation = Quaternion.Euler(0, rotY, 0);
    }
}