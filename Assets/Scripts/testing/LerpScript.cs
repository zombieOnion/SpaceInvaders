using UnityEngine;
using System.Collections;

public class LerpScript : MonoBehaviour {
    public Transform startMarker;
    public Transform startMarker2;
    public Transform endMarker;
    public Transform endMarker2;
    public float speed = 100.0F;
    private float startTime;
    private float journeyLength;
    void Start() {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
        startMarker2 = gameObject.transform;
        startMarker2.eulerAngles = new Vector3(30f, 0f, 0f);
        endMarker2 = gameObject.transform;
        endMarker2.eulerAngles = new Vector3(-30f, 0f, 0f);
    }
    void Update() {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        //transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);
        transform.rotation = Quaternion.Lerp(startMarker2.rotation, endMarker2.rotation, fracJourney);
    }
}