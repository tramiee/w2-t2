using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public List<Transform> waypoint = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDrawGizmos()
    {
        for (int i = 0; i < waypoint.Count; i++)
        {
            if (i < waypoint.Count - 1)
            {
                if (waypoint.Count > 0)
                {
                    Gizmos.color = Color.green;
                    Gizmos.DrawLine(waypoint[i].position, waypoint[i + 1].position);
                }
            }
        }
    }
}
