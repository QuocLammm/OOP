using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public float Time; // tạo biến time xóa đạn
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, Time);//dùng lệnh trong thư viên Unity.
    }
}
