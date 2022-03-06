﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class SaveDataClass
{
    //플레이어 위치 정보
    public Vector2 nextScenePlayerPosition;

    //인벤토리 및 아이템
    public List<ItemClass> itemList;

    //지하 1층
    public bool isFirstGB;
    public bool isUnlocked;
    public bool isDiaryClicked;

    public bool isMufflerPicked;
    public bool isLetterPicked;

    //지하 2층
    public bool alreadyOpen;
    public bool playPuzzleOnce;
    public bool isB3DoorOpened;
    public bool OnB2CandleOnce;
    public bool playB2StatueOnce;
    public bool statue1Fliped, statue2Fliped, statue3Fliped, statue4Fliped;

    //지하 3층
    public bool isPianoMemoGained;
    public bool monsterExtractinInventory; 
    public bool isMonsterDisappear;
    public bool isB4DoorOpened;

    public bool isTreesapPicked;
    public bool isBranchPicked;
    public bool isLeafPicked;
    public bool isFruitPicked;
    public int fruitNum;


    //지하 4층
    public bool isDaggerPicked;
    public bool isJewelGained;
    public bool isB4LockUnlocked;

    public SaveDataClass()
    {
        nextScenePlayerPosition = new Vector2(-32.5f, -0.83f);
        //인벤토리 및 아이템
        itemList = new List<ItemClass>();

        //지하 1층
        isFirstGB = true;
        isUnlocked = false;
        isDiaryClicked = false;

        isMufflerPicked = false;
        isLetterPicked = false;

        //지하 2층
        alreadyOpen = false;
        playPuzzleOnce = false;
        isB3DoorOpened = false;
        OnB2CandleOnce = false;
        playB2StatueOnce = false;
        statue1Fliped = false;
        statue2Fliped = false;
        statue3Fliped = false;
        statue4Fliped = false;

        //지하 3층
        isMonsterDisappear = false;
        isPianoMemoGained = false;
        monsterExtractinInventory = false; //이거 좀 봐야할 듯
        isB4DoorOpened = false;

        isTreesapPicked = false;
        isBranchPicked = false;
        isLeafPicked = false;
        isFruitPicked = false;
        fruitNum = 5;

        //지하 4층
        isDaggerPicked = false;
        isJewelGained = false;
        isB4LockUnlocked = false;
    }
}
