using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            FindAnyObjectByType<GameManager>().AddCollectible();

            Destroy(gameObject);
        }
    }
}
