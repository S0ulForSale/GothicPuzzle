using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    private Vector3 rightPosition; 
    private bool isPlaced;          
    private bool isDragging;       
    private Vector3 offset;        

    void Start()
    {

        rightPosition = transform.position;

        transform.position = new Vector3(Random.Range(-2f, 2f), Random.Range(-1.5f, 1.5f), 0);
    }

    void OnMouseDown()
    {
        if (!isPlaced)
        {
            isDragging = true;
            offset = transform.position - GetMouseWorldPos();
           // GetComponent<SpriteRenderer>().sortingOrder = 10;
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
       // GetComponent<SpriteRenderer>().sortingOrder = 2;
       
        if (Vector3.Distance(transform.position, rightPosition) < 0.5f)
        {
            if( isPlaced ==  false) FindObjectOfType<LevelManager>().PiecePlaced();
            transform.position = rightPosition;
            isPlaced = true; 
            //GetComponent<SpriteRenderer>().sortingOrder = 0;
            GetComponent<Collider2D>().enabled = false;
        }
    }

    void Update()
    {
        if (isDragging && !isPlaced)
        {
            transform.position = GetMouseWorldPos() + offset;
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = 10; 
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}