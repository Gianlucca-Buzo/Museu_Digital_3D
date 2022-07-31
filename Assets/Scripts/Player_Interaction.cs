using UnityEngine;

public class Player_Interaction : MonoBehaviour {

    public float interactionDistance;

    public TMPro.TextMeshProUGUI interactionText;
    // public GameObject interactionHoldGO; // the ui parent to disable when not interacting
    // public UnityEngine.UI.Image interactionHoldProgress; // the progress bar for hold interaction type

    Camera cam;

    void Start(){
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update(){
        Ray ray = cam.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f, 0f));
        RaycastHit hit;

        bool successfulHit = false;

        if (Physics.Raycast(ray, out hit, interactionDistance)) {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null) {
                HandleInteraction(interactable);
                interactionText.text = interactable.GetDescription();
                successfulHit = true;
            }
        }
      	// if we miss, hide the UI
        if (!successfulHit) {
            interactionText.text = "";
        }
    }

    void HandleInteraction(Interactable interactable) {
        KeyCode key = KeyCode.E;
        if (Input.GetKeyDown(key)) {
            interactable.Interact();
        }
    }
}