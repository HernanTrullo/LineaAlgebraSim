using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject vector1;
    [SerializeField] GameObject vector2;

    [SerializeField] TMP_Text text;

    private void Update(){
        text.text = ""+DotProduct();
    }

    private float DotProduct(){
        Vector3 v1 = vector1.transform.position;
        Vector3 v2 = vector2.transform.position;
        return Vector3.Dot(v1.normalized,v2.normalized);
    }
}
