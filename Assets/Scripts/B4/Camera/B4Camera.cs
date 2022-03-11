﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B4Camera : CameraScript
{
    new void Start()
    {
        base.Start();
        player.currRoom = "B4_Hallway";
    }

    // Update is called once per frame
    void Update()
    {
        CameraSetting();
    }

    public override void CameraSetting()
    {
        if(player.currRoom == "B4_Hallway")
        {
            CameraLimit(-28.8f, 28.8f);
        }
        else if(player.currRoom == "B4_Chapel")
        {
            CameraLimit(-4.6f, 4.6f);
        }
        else if(player.currRoom == "B4_Lab")
        {
            CameraLimit(-8.22f, 8.22f);
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
