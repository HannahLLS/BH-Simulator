using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faca : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Player"))
        {
        other.gameObject.GetComponent<VidaDoJogador>().ReceberDano();
        Destroy(gameObject);
        }
    }
}

