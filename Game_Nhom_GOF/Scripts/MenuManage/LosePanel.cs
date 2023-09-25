using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LosePanel : MonoBehaviour
{
    public TextMeshProUGUI score;
    GameObject Infomation;
    private void Start()
    {
        Hide();
    }

    public void Show()
    {
        Time.timeScale = 0;
        gameObject.SetActive(true);
        int scoreI = FindObjectOfType<Killed>().currentKilled * 10;
        score.text = "You get: " + scoreI.ToString() + " Score";
    }
    public void Hide()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            AudioManage.instance.StopSFX("Die");
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Infomation.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
            AudioManage.instance.StopSFX("Die");
            AudioManage.instance.PlayMusic("BackroughMain");
            Time.timeScale = 1;

        }
    }
}
