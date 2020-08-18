using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPlusController : MonoBehaviour
{
    GameManager gm;
    public float rotaSpeed = 2f;
    public bool isGetHp;
    // Start is called before the first frame update
    void Start()
    {
        isGetHp = false;
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotaSpeed, 0);
        GetComponent<ParticleSystem>().Play();
    }

    
}
