using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMove : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> positions;

 // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) //<- intially press -> create a new line
        {
            Destroy(currentLine);//////adddddddddd
            CreateLine();
        }
        if (Input.GetMouseButton(1)) //<- when you hold down, and move far away from the last point
        {
            Vector2 tempPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(tempPos, positions[positions.Count - 1]) > .1f)
            {
                far(tempPos);
            }
        }
    }

    void CreateLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity); //<- cloning the line prefab
        currentLine.tag = ("DrawnWall");//////adddddddd
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        positions.Clear(); //<- resets the points of the cloned line
        positions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition)); //<-add
        positions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition)); //<-add
        lineRenderer.SetPosition(0, positions[0]); //<- add the points to line renderer
        lineRenderer.SetPosition(1, positions[1]); //<- add the points to line renderer
    }

    void far(Vector2 newpos)
    {
        positions.Add(newpos); // <- adds the new position to the list
        lineRenderer.positionCount++; //<- increase number of positions
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newpos); //<- add it to the line renderer
        edgeCollider.points = positions.ToArray(); //<- add it to the edgeCollider
    }
}
