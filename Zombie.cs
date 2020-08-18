using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody rb;
    GameManager gm;
    PlayerController pc;
    //bool gameover;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = GetComponent<GameManager>();
        rb.velocity = transform.forward * speed; //forward = z축 플러스
        Destroy(gameObject, 4f);
        //gameover = false;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        pc = other.GetComponent<PlayerController>();
    //        if (pc != null)//컨퍼넌트가 정상적으로 들어왓는지 
    //        {
    //            //ani.SetTrigger("DeathTrigger");
    //            pc.Die();
    //        }
    //    }
    //}
}
