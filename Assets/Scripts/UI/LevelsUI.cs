using UnityEngine;

public class LevelsUI : MonoBehaviour
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
    public void btLvl1()
    {
        scene.Lvl1();
    }
    public void btLvl2()
    {
        scene.Lvl2();
    }
    public void btLvl3()
    {

    }
}
