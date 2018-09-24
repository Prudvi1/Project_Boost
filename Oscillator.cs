using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]

public class Oscillator : MonoBehaviour {

    [SerializeField] Vector3 Movement = new Vector3(10f, 10f, 10f);
    float MovementFactor; 
    [SerializeField] float period = 2f;

    // Use this for initialization
    Vector3 InitialPosition;
    void Start () {
        InitialPosition = transform.position;
	}
	// Update is called once per frame
	void Update () {
        if (period <= Mathf.Epsilon)
        {
            return;
        }
        float cycles = Time.time / 2f;
        float tau = Mathf.PI * 2f;
        float raSinWave = Mathf.Sin(cycles * tau);

        MovementFactor = raSinWave / 2f +0.5f;

        Vector3 offset = Movement * MovementFactor;
        transform.position = InitialPosition + offset;  
	}
}
