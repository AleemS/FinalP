using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S04a_inputKbdPos : MonoBehaviour {

  void Update() {
    float x = Input.GetAxis("Horizontal"); // left/right arrow keys (AD keys)
    float z = Input.GetAxis("Vertical");   // up/down arrow keys (WS keys)
    // The values of x and z are between -1.0 and 1.0
    Debug.Log(string.Format("x={0,4}  z={1,4}", x, z));
    transform.position = new Vector3(x, 0.5f, z);
  }
}

