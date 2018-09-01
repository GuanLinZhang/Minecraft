using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day_Night_Controller : MonoBehaviour {

    //定义Directional Light旋转速度
    private float rotatingSpeed = 10;

	
	//更新Y轴旋转角度模拟日夜变换
	void Update () {
        transform.Rotate(Vector3.up * rotatingSpeed * Time.deltaTime, Space.Self);
	}
}
