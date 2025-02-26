﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript2 : MonoBehaviour
{
    public AudioClip coinSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 15 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<PlayerScript>().points--;
            Destroy(gameObject);

            AudioSource.PlayClipAtPoint(coinSound, transform.position);

        }
    }
}

