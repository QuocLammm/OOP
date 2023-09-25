using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Main : MonoBehaviour
{
    public void OnClickMenuButton()
    {
        Time.timeScale = 0; // dừng lại thời gian của game
                            // thực hiện các thao tác cần thiết cho menu, ví dụ như hiển thị menu UI
    }

    public void OnClickResumeButton()
    {
        Time.timeScale = 1; // khôi phục lại thời gian của game
                            // thực hiện các thao tác cần thiết để tiếp tục game, ví dụ như ẩn menu UI
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        AudioManage.instance.PlayMusic("BackroughMain");
        AudioManage.instance.StopSFX("Die");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
