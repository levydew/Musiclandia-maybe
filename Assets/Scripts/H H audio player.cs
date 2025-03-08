using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HHaudioplayer : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    [SerializeField] public GameObject Audiotrigger;
    public AsyncController async;
    public GameObject youdontgettogoanywhere;
    public string currentscene;
    
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
        currentscene = "Scenes/" + scene.name;
        Debug.Log(currentscene);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        audio.Play();
        youdontgettogoanywhere.SetActive(true);
        StartCoroutine(WaitForSound(audio));

    }
    IEnumerator WaitForSound(AudioSource audio)
    {
       yield return new WaitUntil(() => audio.isPlaying == false);
       // or yield return new WaitWhile(() => audiosource.isPlaying == true);
       if(currentscene == "Scenes/level1"){
        async.loadLevelBtn("Scenes/level2");
       }
        else
        {
            async.loadLevelBtn("Scenes/End1");
        }
    }
}
