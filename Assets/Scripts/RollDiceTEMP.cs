using UnityEngine;

public class RollDiceTEMP : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Roll();
    }

    public void Roll()
    {
        // Add a random upward force
        rb.AddForce(Vector3.up * Random.Range(5f, 8f), ForceMode.Impulse);

        // Add a chaotic rotational spin (torque)
        Vector3 randomTorque = new Vector3(
            Random.Range(-10f, 10f),
            Random.Range(-10f, 10f),
            Random.Range(-10f, 10f)
        );
        rb.AddTorque(randomTorque, ForceMode.Impulse);
    }
}
