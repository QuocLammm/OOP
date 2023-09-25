using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;// lưu trữ đạn
    public GameObject muzze;//hiệu ưng
    public Transform[] fire;// lưu trữ nơi tạo ra viên đạn
    public float bulletFore;// lực của viên đạn
    public float Timefire = 0.2f;// kiểm soát bắn nhanh hay bắn chậm
    public GameObject fireEf;// lưu nơi đạn bắn ra
    public int minDamage = 2;
    public int maxDamage = 5;
    private float timefire; // quản lý thời gian đạn ra


    // Được gọi liên tụ trong quá trình chạy gảe
    void Update()
    {
        Shot();
        timefire -= Time.deltaTime;// sau 1.5s thì bắn 1 lần
        if (Input.GetMouseButton(0) && timefire < 0)// ấn chuột trái thì sẽ bắn ra đạn
        {
            Fire();
        }
    }
    void Shot()// Phương thức shot người chơi bấm nút bắn súng
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);// hàm lấy vị trí con chuột 
        Vector2 look = mouse - transform.position;
        float angle = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.Euler(0, 0, angle);
        transform.rotation = rotation;

        if (transform.eulerAngles.z > 90 && transform.eulerAngles.z < 270)
            transform.localScale = new Vector3(1, -1, 0);
        else
            transform.localScale = new Vector3(1, 1, 0);
    }
    void Fire()
    {
        foreach (Transform spawn in fire)
        {
            Instantiate(muzze, spawn.position, transform.rotation, transform);
            var bulletT = Instantiate(bullet, spawn.position, Quaternion.identity);
            var fireE = Instantiate(fireEf, spawn.position, transform.rotation, transform);
            
            Bullet bulletC = bulletT.GetComponent<Bullet>();
            bulletC.minDamage = minDamage;
            bulletC.maxDamage = maxDamage;
            timefire = Timefire;
            Rigidbody2D rb = bulletT.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.right * bulletFore, ForceMode2D.Impulse);
            AudioManage.instance.PlaySFX("FireGun");
        }
    }
}
