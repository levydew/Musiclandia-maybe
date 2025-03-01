using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanging : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void ChangeScene()
   {
        SceneManager.LoadScene("Stuff");
   }
}
