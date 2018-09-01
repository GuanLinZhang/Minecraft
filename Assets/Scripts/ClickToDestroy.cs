using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDestroy : MonoBehaviour {
    //当物体检测到鼠标点击该自身，自身销毁
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
