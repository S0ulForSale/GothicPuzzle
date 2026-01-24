using UnityEngine;

public class PauseUI : MonoBehaviour
{
    private SceneLoader scene;
    private LevelManager levelManager;

    private void Start()
    {
        //audioManager = AudioManager.Instance;
        scene = SceneLoader.Instanse;
    }

    public void Continue()
    {
        levelManager.closePauseUI();
    }

    public void btRestart()
    {
        scene.RestartLevel();
    }

    public void btLevels()
    {
        scene.Levels();
    }
    public void btSettings()
    {
        scene.Settings();
    }
    
}
