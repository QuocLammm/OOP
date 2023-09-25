using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading.Tasks;

public class LoadingManage : MonoBehaviour
{
    [SerializeField] public GameObject _LoadingScene;
    [SerializeField] public Slider _LoadingFill;

    public void LoadScene(int index)
    {
        StartCoroutine(LoadSceneAsyn(index));
    }

    IEnumerator LoadSceneAsyn(int index)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(index);
        _LoadingScene.SetActive(true);
        _LoadingFill.value = 0;
        while (!op.isDone) 
        {
            float pro = Mathf.Clamp01(op.progress/0.9f);
            _LoadingFill.value = pro;    
            yield return null;
        }
    }

}
