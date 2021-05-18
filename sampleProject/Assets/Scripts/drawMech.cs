using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawMech : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> positions;

    public int maxHealth = 100;
    public float currentHealth;

    public healthMech healthBar;
    public levelchanger levelChanger;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Destroy(currentLine);
                CreateLine(touch);
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 tempPos = Camera.main.ScreenToWorldPoint(touch.position);
                if (Vector2.Distance(tempPos, positions[positions.Count - 1]) > .1f)
                {
                    far(tempPos);
                }
            }
        }
        if (isEmpty(currentHealth)) 
        {   
            Debug.Log("lose"); // logs correctly now
            levelChanger.lose();
        }
    }
    public bool isEmpty(float health)
    {
        if (health < 0) {
            return true;
        }
        return false;
    }
    void CreateLine(Touch touch)
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        currentLine.tag = ("DrawnWall");
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        positions.Clear();
        positions.Add(Camera.main.ScreenToWorldPoint(touch.position));
        positions.Add(Camera.main.ScreenToWorldPoint(touch.position));
        lineRenderer.SetPosition(0, positions[0]);
        lineRenderer.SetPosition(1, positions[1]);
    }


    void far(Vector2 newpos)
    {
        positions.Add(newpos);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newpos);
        edgeCollider.points = positions.ToArray();

        //adjusting healthbar
        Debug.Log("damage");
        currentHealth -= 0.5f;
        healthBar.SetHealth(currentHealth);

    }
}
