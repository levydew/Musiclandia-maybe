using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

public class HHaudioplayer : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    [SerializeField] public GameObject Audiotrigger;
    public AsyncController async;
    public GameObject youdontgettogoanywhere;
    
    

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
       
        async.loadLevelBtn("Scenes/Levels/level2");
    }
}
