using UnityEngine;

public class WinUI : MonoBehaviour
{
    private SceneLoader scene;

    private void Start()
    {
        //audioManager = AudioManager.Instance;
        scene = SceneLoader.Instanse;
    }

    public void btLevels()
    {
        
    }
    public void btSettings()
    {

    }
    public void btRestart()
    {
        scene.RestartLevel();
    }
}
