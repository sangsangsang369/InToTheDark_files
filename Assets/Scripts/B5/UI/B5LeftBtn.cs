﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B5LeftBtn : MonoBehaviour
{
    public GameObject playerObj;
    bool OnClick;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.currRoom == "B5_Hallway")
        {
            LeftLimit(0);
        }
        else if (player.currRoom == "Estrade")
        {
            LeftLimit(20.5f);
        }
    }
    private void LeftLimit(float limit)
    {
        if (OnClick && playerObj.transform.position.x > limit)
        {
            playerObj.transform.position += Vector3.left * player.speed * Time.deltaTime;
        }
    }
    public void LeftBtnUp()
    {
        OnClick = false;
        player.GetComponent<Animator>().SetBool("isWalking", false);
    }
    public void LeftBtnDown()
    {
        OnClick = true;
        player.GetComponent<Animator>().SetBool("isWalking", true);
        player.GetComponent<SpriteRenderer>().flipX = true;
    }
}
