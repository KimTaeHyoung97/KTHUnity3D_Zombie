using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 8f;
    Animator ani;
    GameManager gm;
    //private int key;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        gm = FindObjectOfType<GameManager>();
        //key = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        ani.SetTrigger("WalkTrigger");
        //키보드입력 = 스위치플랫폼 어느상황에서도 사용
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //if (Input.GetAxis("Horizontal") < 0) key = -1;
        //if (Input.GetAxis("Horizontal") > 0) key = 1;

        float xSpeed = speed * xInput;
        float zSpeed = speed * zInput;

        rb.velocity = new Vector3(xSpeed, 0, zSpeed);
        //캐릭터 회전
        transform.LookAt(transform.position + rb.velocity);
    }

    //public void Del()
    //{
    //    gameObject.SetActive(false);

    //    //gm.EndGame();
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombie"))
        {
            gm.MiunsHp();
            GetComponent<ParticleSystem>().Play();
        }
        if (other.CompareTag("HpBox"))
        {
            //Debug.Log("박스삭제");
            other.gameObject.SetActive(false);
            gm.PlusHp();

        }
    }
}
