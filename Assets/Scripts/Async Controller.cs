using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AsyncController : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private GameObject gameSelect;

    [SerializeField] private Slider loadingSlider;

    public void loadLevelBtn(string levelToload)
    {
        gameSelect.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(LoadlevelAsync(levelToload));

    }
    IEnumerator LoadlevelAsync(string levelToLoad)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
        
        while (!loadOperation.isDone) 
        {
            float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            loadingSlider.value = progressValue;
            yield return null;  
        }
    }
}
