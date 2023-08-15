using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<PlayerMovement>(out PlayerMovement player))
        {
            Collect();
        }
    }

    private void Collect()
    {
        Destroy(gameObject);
    }
}
