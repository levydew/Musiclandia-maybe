using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gohome : MonoBehaviour
{
   void Gohome()
   {
    AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);
   }
}