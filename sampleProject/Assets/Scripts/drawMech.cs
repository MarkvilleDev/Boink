using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawMech : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> positions; //<-----
    
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
    }
}
