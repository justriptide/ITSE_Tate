using UnityEngine;

public class Spinner : MonoBehaviour
{
    public Vector3 spinControl = Vector3.zero;
    Transform tf;

    void Start()
    {
        tf = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        tf.Rotate(spinControl * Time.deltaTime);
    }
}
