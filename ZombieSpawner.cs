using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRateMin = .5f;
    public float spawnRateMax = 3f;

    private Transform target;
    private float spawRate;//span
    private float timeAfterSpawn;//delta

    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spawRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn >= spawRate)
        {
            timeAfterSpawn = 0f;

            GameObject bullet = Instantiate(bulletPrefab, transform.position
                , transform.rotation);//프리팹,위치,회전값
            bullet.transform.LookAt(target);//LootAt = 내 정면이 타켓을 바라보게끔 회전한다.
        }
    }
}
