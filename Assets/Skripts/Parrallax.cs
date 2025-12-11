using UnityEngine;

public class Parrallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;  // Reference to the MeshRenderer component
    public float animationSpeed = 1f;   // Speed at which the background scrolls

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // Get the MeshRenderer component attached to this GameObject
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Scroll the texture horizontally based on animationSpeed
        // Time.deltaTime ensures smooth movement independent of frame rate
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
