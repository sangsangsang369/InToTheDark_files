﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorToB4 : Object
{
    public GameObject doorToB4_noEnterUI, doorToB4_EnterUI;
    public Text doorToB4_noEnterText, doorToB4_EnterText;
    public Text inputTextUI;
    InventoryMng inventoryMng; 
    B3UIManager uiManager;
    SlotSelectionMng slotSelectMng;

    DataManager data;
    SaveDataClass saveData;
    public bool isB4DoorOpened;
    public GameObject creature;

    void Start()
    {
        data = DataManager.singleTon;
        saveData = data.saveData;
        isB4DoorOpened = saveData.isB4DoorOpened;

        inventoryMng = FindObjectOfType<InventoryMng>();
        uiManager = FindObjectOfType<B3UIManager>();
        slotSelectMng = FindObjectOfType<SlotSelectionMng>();

        if(isB4DoorOpened)
        {
            creature.SetActive(false);
        }
    }

    public override void ObjectFunction()
    {
        //투명한 액체 선택 안 됐을 때 && 문 열린 적 없을 때
        if(slotSelectMng.usableItem != "liquidSelected" && !isB4DoorOpened) 
        {
            doorToB4_noEnterUI.SetActive(true); //들어갈 수 없다는 텍스트 출력
            StartCoroutine(uiManager.LoadTextOneByOne(doorToB4_noEnterText.text, inputTextUI));
        }
        //투명한 액체 선택 됐을 때 && 문 열린 적 없을 때
        else if(slotSelectMng.usableItem == "liquidSelected" && !isB4DoorOpened)
        {
            doorToB4_EnterUI.SetActive(true); //문 열렸다는 텍스트 출력
            StartCoroutine(uiManager.LoadTextOneByOne(doorToB4_EnterText.text, inputTextUI));
            creature.SetActive(false); //문에 붙은 이형체 꺼주기
            
            inventoryMng.RemoveFromInventory(slotSelectMng.selectedItem, ItemClass.ItemPrefabOrder.Liquid);
            slotSelectMng.SelectionClear(); 
            
            isB4DoorOpened = true; //문 열림
            saveData.isB4DoorOpened = true;
            data.Save();
        }
        else if(isB4DoorOpened)
        {
            //B4로 씬 이동
            saveData.playerXstartPoint = saveData.playerXstartPoints[(int)SaveDataClass.playerStartPoint.B4leftDoor];
            data.Save();
            SceneManager.LoadScene("B4");
        }
    }
}
