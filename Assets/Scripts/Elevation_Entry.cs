using UnityEngine;

public class TilemapScript : MonoBehaviour
{
    public Collider2D[] mountainColliders;
    public Collider2D[] boundaryColliders;

    private int initialPlayerOrder = 5;
    private int elevatedPlayerOrder = 15;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (Collider2D mountain in mountainColliders)
            {
                Debug.Log("Mountain collider triggered");
                mountain.enabled = !mountain.enabled; 
            }

            foreach (Collider2D boundary in boundaryColliders)
            {
                Debug.Log("Boundary collider triggered");
                boundary.enabled = !boundary.enabled;
            }

            setPlayerSortingOrder(collision);
        }
    }

    private void setPlayerSortingOrder(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder == initialPlayerOrder)
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = elevatedPlayerOrder;
        }
        else
        {
            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = initialPlayerOrder;
        }

      
        
    }
}
