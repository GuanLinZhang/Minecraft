using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //声明存在的BackPackInventory
    public GameObject BodyInventory;

    //获得键盘Tab键输入，激活或者消失BackPackInventory
	void Update () {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (BodyInventory.activeSelf)
            {
                BodyInventory.SetActive(false);
            }
            else
            {
                BodyInventory.SetActive(true);
            }
        }
	}
}
