
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

class Coin : Template
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Spike spike))
            gameObject.SetActive(false);
    }
}
