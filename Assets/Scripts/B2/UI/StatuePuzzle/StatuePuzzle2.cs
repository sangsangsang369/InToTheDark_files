﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatuePuzzle2 : Object
{
    B2_UIManager uiManager;
    Player player;
    public bool statue2Fliped = false;

    DataManager data;
    SaveDataClass saveData;
    // Start is called before the first frame update
    void Start()
    {
        data = DataManager.singleTon;
        saveData = data.saveData;
        statue2Fliped = saveData.statue2Fliped;

        player = FindObjectOfType<Player>();
        uiManager = FindObjectOfType<B2_UIManager>();
    }

    // Update is called once per frame
    public override void ObjectFunction()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!statue2Fliped)
            {
                this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
                statue2Fliped = true;
                saveData.statue2Fliped = true;
                data.Save();
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
                statue2Fliped = false;
                saveData.statue2Fliped = false;
                data.Save();
            }
        }
    }
}

