using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    private int _coins = 0;

    public event UnityAction<int> CoinsChanged;
    public event UnityAction Crashed;

    public void PickUpCoin()
    {
        _coins++;
        CoinsChanged?.Invoke(_coins);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
        {
            coin.gameObject.SetActive(false);
            PickUpCoin();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Spike spike))
            Crashed?.Invoke();
    }
}
