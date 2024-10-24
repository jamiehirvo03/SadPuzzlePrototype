using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WaterPuzzle1 : MonoBehaviour
{
    [SerializeField] private float waterLevel;

    public Vector3 waterLevelMinimum;
    public Vector3 waterLevelMaximum;

    public float fillSpeed;

    // Start is called before the first frame update
    void Start()
    {
        waterLevel = 100f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Teardrop")
        {
            if (transform.position != waterLevelMaximum)
            {
                transform.position = Vector3.Lerp(waterLevelMinimum, waterLevelMaximum, fillSpeed);
            }
        }
    }
}
