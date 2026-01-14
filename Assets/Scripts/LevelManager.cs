using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int totalPieces;
    private int currentPieces;

    void Start()
    {
        currentPieces = 0;
    }

    public void PiecePlaced()
    {
        currentPieces++;
        Debug.Log(currentPieces);
        if (currentPieces == totalPieces)
        {
            Debug.Log("WIN");
        }
    }
}
