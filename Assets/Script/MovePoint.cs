using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoint : MonoBehaviour
{
    [SerializeField] GameObject vecX;
    [SerializeField] GameObject vecY;
    [SerializeField] GameObject vecZ;


    VectorClip sVectorX;
    VectorClip sVectorY;
    VectorClip sVectorZ;


    private Vector3 offset;
    private Vector3 cursorPosition;
    private Vector3 localPosition;

    void Start() {
        sVectorX = vecX.GetComponent<VectorClip>();
        sVectorY = vecY.GetComponent<VectorClip>();
        sVectorZ = vecZ.GetComponent<VectorClip>();


    }
    // Update is called once per frame
    void Update()
    {
        if (sVectorX.getIsPressed()){
            localPosition = sVectorX.getPositionParent();
            cursorPosition = getPositionMouseCamera() + sVectorX.getOffset();
            transform.position = new Vector3(cursorPosition.x,localPosition.y,localPosition.z);
        }
        if (sVectorY.getIsPressed()){
            localPosition = sVectorY.getPositionParent();
            cursorPosition = getPositionMouseCamera() + sVectorY.getOffset();
            transform.position = new Vector3(localPosition.x,cursorPosition.y,localPosition.z);
        }
        if (sVectorZ.getIsPressed()){
            localPosition = sVectorZ.getPositionParent();
            cursorPosition = getPositionMouseCamera() + sVectorZ.getOffset();
            transform.position = new Vector3(cursorPosition.x,cursorPosition.y,localPosition.z);
        }
    }

    private Vector3 getPositionMouseCamera(){
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
