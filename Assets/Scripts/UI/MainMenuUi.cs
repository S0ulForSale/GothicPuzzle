using UnityEngine;

public class MainMenuUi : MonoBehaviour
{
    private SceneLoader scene;

    private void Start()
    {
        //audioManager = AudioManager.Instance;
        scene = SceneLoader.Instanse;
    }

    public void btPlay()
    {
        scene.Levels();
    }
    public void btSettings()
    {
        scene.Settings();
    }
    public void btAbout()
    {
        scene.About();
    }
    public void btExit()
    {
       
    }
}
