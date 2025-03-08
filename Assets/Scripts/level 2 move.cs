using UnityEngine;

public class level2move : MonoBehaviour
{
    public AsyncController async;

    private void OnTriggerEnter(Collider load)
    {
        async.loadLevelBtn("Scenes/Levels/level3");
    }
}
