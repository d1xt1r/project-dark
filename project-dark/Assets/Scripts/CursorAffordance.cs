using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAffordance : MonoBehaviour {

    public Texture2D walkCursor;
    public Texture2D targetCursor;
    public Texture2D unknownCursor;
    public Vector2 cursorHotspot = new Vector2(96, 96);

    CameraRaycaster cameraRaycaster;

	// Use this for initialization
	void Start () {
        cameraRaycaster = GetComponent<CameraRaycaster>();
    }
	
	// Update is called once per frame
	void Update () {
        if (cameraRaycaster.layerHit == Layer.Walkable) {
            Cursor.SetCursor(walkCursor, cursorHotspot, CursorMode.Auto);
        } if (cameraRaycaster.layerHit == Layer.Enemy) {
            Cursor.SetCursor(targetCursor, cursorHotspot, CursorMode.Auto);
        } if (cameraRaycaster.layerHit == Layer.RaycastEndStop) {
            Cursor.SetCursor(unknownCursor, cursorHotspot, CursorMode.Auto);
        } else {
            Debug.Log("No cursor assigned for this layer");
        }
	}
}
