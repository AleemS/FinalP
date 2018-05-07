using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GetItem : MonoBehaviour {

	public Text CountText;

    private Rigidbody pl;
    private int count;
	// Use this for initialization
	void Start () {
        pl = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Items"))
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
	}

	void SetCountText()
	{
		CountText.text = "Items: " + count.ToString ();
	}
}
