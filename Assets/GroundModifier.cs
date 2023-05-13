using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundModifier : MonoBehaviour
{
    [SerializeField] private Transform leftSide;
    [SerializeField] private Transform rightSide;

    private void Awake()
    {
        var scaleFactor = new Vector3(0, 0, Random.Range(4f, 9f));
        var direction = Random.Range(0, 1);

        leftSide.localScale = direction == 0 ? leftSide.localScale + scaleFactor : leftSide.localScale - scaleFactor;
        rightSide.localScale = direction == 1? rightSide.localScale + scaleFactor : rightSide.localScale - scaleFactor;


    }
}
