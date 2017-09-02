using UnityEngine;

public class MoveCursor : MonoBehaviour {

    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            transform.position = new Vector3(hit.point.x, 0, hit.point.z);
        }
    }
}
