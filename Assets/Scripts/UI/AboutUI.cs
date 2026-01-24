using UnityEngine;

public class AboutUI : MonoBehaviour
{
    private SceneLoader scene;

    private void Start()
    {
        //audioManager = AudioManager.Instance;
        scene = SceneLoader.Instanse;
    }

    public void btBack()
    {
        scene.MainMenu();
    }
}
