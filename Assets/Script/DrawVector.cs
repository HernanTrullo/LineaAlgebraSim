using UnityEngine;

public class DrawVector : MonoBehaviour
{
    [SerializeField] private Vector3 p0 = Vector3.zero;
    [SerializeField] private Vector3 p1 = new Vector3();
    private LineRenderer lineRenderer;
    // Start is called before the first frame update

    /// <sumary>
    /// for draw line render
    /// <sumanry>
    private void drawRender(){
        p1 = transform.position;
        lineRenderer.SetPositions(new Vector3[]{p0, p1});
    }
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        drawRender();
    }
    

    // Update is called once per frame
    void Update()
    {
        drawRender();
    }
}
