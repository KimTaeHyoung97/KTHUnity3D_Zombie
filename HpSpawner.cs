using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpSpawner : MonoBehaviour
{
    public GameObject hpPrefab;

    public float spawRate = 10f;//span
    private float timeAfterSpawn = 0f;//delta

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;
        if (timeAfterSpawn >= spawRate)
        {
            timeAfterSpawn = 0f;

            GameObject hpBox = Instantiate(hpPrefab);
            int px = Random.Range(-8, 9);
            int pz = Random.Range(-8, 9);

            hpBox.transform.position = new Vector3(px, 1, pz);

        }
    }
}
