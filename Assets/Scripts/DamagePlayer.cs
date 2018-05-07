using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamagePlayer : MonoBehaviour {

	public float timeBetweenAttacks = 0.5f;
	public int damageAmount = 2;

	GameObject player;
	PlayerHP playerhealth;
	bool playerInRange;
	float timer;

	//private int damage = 1;

	// Use this for initialization
	void Start () {
		//playerhealth = player.GetComponent ();
	}
}


