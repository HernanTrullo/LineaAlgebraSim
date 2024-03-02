using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class VectorClip : MonoBehaviour
{
    // Start is called before the first frame update
    private float deltaLength = 0.02f;
    private bool isPressed = false;
    private Vector3 deltaVector;
    private Vector3 lengthVector;
    private Vector3 offset;
    private Vector3 positionParent;


    private void Start() {
        lengthVector = transform.localScale;
        deltaVector = new Vector3(deltaLength, 0, deltaLength);
    }
    
    private void OnMouseDown() {
        isPressed = true;
        offset = transform.parent.localPosition - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        positionParent = transform.parent.localPosition;
    }
    private void OnMouseUp() {
        isPressed = false;
    }
    private void OnMouseEnter() {
        transform.localScale = lengthVector + deltaVector;
    }
    private void OnMouseExit() {
        transform.localScale = lengthVector;
    }
    
    
    public void setPosition(Vector3 vector){
        transform.position = vector;
    }
    public Vector3 getPOsition(){
        return transform.position;
    }
    public bool getIsPressed(){
        return isPressed;
    }
    public Vector3 getOffset(){
        return offset;
    }
    public Vector3 getPositionParent(){
        return positionParent;
    }
}
