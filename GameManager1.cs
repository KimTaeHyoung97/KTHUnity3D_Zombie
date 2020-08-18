using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager1 : MonoBehaviour
{//시작화면
    Text zombieText, gamestratText;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        zombieText = GameObject.Find("ZomblieText").GetComponent<Text>();
        gamestratText = GameObject.Find("GameStrat").GetComponent<Text>();

        ani = FindObjectOfType<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ani.SetTrigger("WalkTrigger");
    }
    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
        zombieText.gameObject.SetActive(false);
        gamestratText.gameObject.SetActive(false);
    }
}
