﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MoveStatue : MonoBehaviour
{
    B2_UIManager uiManager;
    public StatuePuzzle SP;
    public StatuePuzzle2 SP2;
    public StatuePuzzle3 SP3;
    public StatuePuzzle4 SP4;
    public InventoryMng inventoryMng;
    public GameObject sword2UI, sword2Img;
    public Text sword2Text;
    public Text inputTextUI;
    bool playOnce = false;

    void Start()
    {
        uiManager = FindObjectOfType<B2_UIManager>();
        inventoryMng = FindObjectOfType<InventoryMng>();
    }


    void Update()
    {
        if((SP.statue1Fliped) && (SP2.statue2Fliped) && (!SP3.statue3Fliped) && (SP4.statue4Fliped))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && (!playOnce))
            {
                CheckAnswer();
            }
        }
    }

    public void CheckAnswer()
    {
        sword2UI.SetActive(true);
        StartCoroutine(uiManager.LoadTextOneByOne(sword2Text.text, inputTextUI));
        GameObject sword2 = sword2Img;
        inventoryMng.AddToInventory(sword2);
        playOnce = true;
    }
}
