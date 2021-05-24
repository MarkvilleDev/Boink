using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class drawMech : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;
    public int[] health = new int [17];

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> positions;

    public int maxHealth;
    public float currentHealth;

    public healthMech healthBar;
    public levelchanger levelChanger;

    void Start()
    {
        health[0] = 10;
        health[1] = 20;
        health[2] = 200;
        health[3] = 100;


        maxHealth = health[SceneManager.GetActiveScene().buildIndex - 5];
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
        // Debug.Log("is empty" + isEmpty(currentHealth));
        if (isEmpty(currentHealth)) 
        {   
           // logs correctly now
            // GameObject.FindGameObjectWithTag("DrawnwWall").SetActive(false);
            Debug.Log("before lose");
            levelChanger.lose();
            Debug.Log("After Lose");
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
            healthBar.SetHealth(0.1f);
            currentHealth = 1f;
            Debug.Log("u lose"); 
        }
    }
    public bool isEmpty(float health)
    {
        if (health <= 0) {
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
        Debug.Log(currentHealth);
        currentHealth -= 0.5f;
        healthBar.SetHealth(currentHealth);

    }
}
