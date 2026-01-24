using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject winUi;
    [SerializeField] private GameObject pauseUI;
    [SerializeField] private int totalPieces;
    private int currentPieces;

    void Start()
    {
        currentPieces = 0;
        winUi.SetActive(false);
        pauseUI.SetActive(false);
    }

    public void PiecePlaced()
    {
        currentPieces++;
        Debug.Log(currentPieces);
        if (currentPieces == totalPieces)
        {
            Debug.Log("WIN");
            WinUi();
        }
    }
    public void PauseUI()
    {
        pauseUI.SetActive(true);
    }
    public void closePauseUI()
    {
        pauseUI.SetActive(false);
    }
    private void WinUi()
    {
        winUi.SetActive(true);
    }
}
