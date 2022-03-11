﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B3CameraLimit : CameraScript
{
    new void Start()
    {
        base.Start();
        player.currRoom="B3_Hallway";
    }

    // Update is called once per frame
    void Update()
    {
        CameraSetting();
    }

    public override void CameraSetting()
    {
        if (player.currRoom=="B3_Hallway")
        {
            CameraLimit(-28.8f, 28.8f);
        }
        if (player.currRoom=="B3_Treeroom")
        {
            CameraLimit(-12.7f, 12.7f);
        }
        if (player.currRoom=="B3_Pianoroom")
        {
            CameraLimit(-8.5f, 8.5f);
        }
    }

    // private void CameraLimit(float limit)
    // {
    //     if(mainCharacter.transform.position.x <= -limit || mainCharacter.transform.position.x >= limit)
    //     {
    //         if(switchCamera == false) 
    //         {
    //             switchCamera = true;
    //             if(this.transform.position.x <= -limit) // 왼쪽 끝 넘어가면
    //             {
    //                 this.transform.SetParent(cameraParent.transform);
    //                 this.transform.position = new Vector3(-limit, this.transform.position.y, -10); // 왼쪽 끝으로 카메라 위치 재조정
    //                 this.transform.localScale = new Vector3(0.7f, 0.7f, 1);
    //             }
    //             else if(this.transform.position.x >= limit) // 오른쪽 끝 넘어가면
    //             {
    //                 this.transform.SetParent(cameraParent.transform);
    //                 this.transform.position = new Vector3(limit, this.transform.position.y, -10); // 오른쪽 끝으로 카메라 위치 재조정
    //                 this.transform.localScale = new Vector3(0.7f, 0.7f, 1);
    //             }
    //         }
    //     }
    //     else
    //     {
    //         if(switchCamera == true)
    //         {
    //             switchCamera = false;
    //             this.transform.SetParent(mainCharacter.transform); // 카메라의 Parent를 player로 다시 바꿔줌
    //             playerCamera.transform.localPosition = new Vector3(0, this.transform.localPosition.y, -10);
    //             this.transform.localScale = new Vector3(1, 1, 1);
    //         }
    //     }
    // }
}

