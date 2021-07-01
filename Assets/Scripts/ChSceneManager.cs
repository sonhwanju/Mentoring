using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ChSceneManager : MonoBehaviour
{
    public static ChSceneManager instance;
    public CanvasGroup fadeImg;
    public GameObject panel;
    public Text lText;

    void Start()
    {
        if(instance != null) {
            Destroy(gameObject);
            return;
        }
        instance = this;

        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void ChangeScene(string sceneName) {
        fadeImg.DOFade(1, 2f).OnStart(() => {
            fadeImg.blocksRaycasts = true;
        }).OnComplete(() =>{
            StartCoroutine(Load(sceneName));
        });
    }

    IEnumerator Load(string sceneName) {
        panel.SetActive(true);
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);
        async.allowSceneActivation = false;

        float time = 0f;
        float percent = 0f;

        while(!async.isDone) {
            yield return null;
            time+= Time.deltaTime;

            if(percent >= 90f) {
                percent = Mathf.Lerp(percent, 100f, time);

                if(percent == 100) {
                    async.allowSceneActivation = true;
                }
            }
            else {
                percent = Mathf.Lerp(percent, async.progress * 100f, time);
                if(percent >= 90f) time = 0;
            }
            lText.text = percent.ToString("0") + "%";
        }  
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        fadeImg.DOFade(0, 2f).OnStart(() => {
            panel.SetActive(false);
        }).OnComplete(() => {
            fadeImg.blocksRaycasts = false;
        });
    }
}
