﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    Image healthBar;
    public float maxHealth;
    public static float health;

	void Start () {
        healthBar = GetComponent<Image>();
        health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.fillAmount= health / maxHealth;
	}
}
