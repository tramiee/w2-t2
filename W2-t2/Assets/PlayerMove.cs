using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float PlayerSpeed;
    [SerializeField] float rotationSpeed;
    Transform NextPos;
    int NextPosIndex;
    // Start is called before the first frame update
    void Start()
    {
        NextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObjects();
    }

    public void MoveGameObjects()
    {
        if (transform.position == NextPos.position)
        {
            NextPosIndex++;
            if (NextPosIndex >= Positions.Length)
            {
                NextPosIndex = 0;
            }
            NextPos = Positions[NextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, PlayerSpeed * Time.deltaTime);
            Vector3 directionToTarge = NextPos.position - transform.position;
            Quaternion rotationToTarge = Quaternion.LookRotation(directionToTarge);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotationToTarge, rotationSpeed * Time.deltaTime);
        }
    }
}
