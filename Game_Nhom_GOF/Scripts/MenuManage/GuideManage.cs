using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GuideManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Show();
    }
    public void Hide()
    {
        Time.timeScale = 1; // dừng lại thời gian của game
        gameObject.SetActive(false);    // thực hiện các thao tác cần thiết cho menu, ví dụ như hiển thị menu UI
        AudioManage.instance.musicSource.Play();
        AudioManage.instance.PlayMusic("Backrough");;
    }
    public void Show()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
        AudioManage.instance.musicSource.Stop();
    }
}
