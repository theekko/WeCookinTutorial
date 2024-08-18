using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour {

    [SerializeField] private BaseCounter baseCounter;
    [SerializeField] private GameObject[] visualGameObjectArray;

    private void Start() {
        // I want specifically a reference to the Player object. I want all the information that object has
        // and I could do that with a serializedField, but that can cause there to be a lot of serielized fields
        // Instead I will reference a specfic Isnatance that will hold all of the information of the player object.
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;

    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e) {
        // Clear counter is the prefab so when looking at clearCounter you will be looking at every instance of that
        // prefab and determining whether or not to turn the selected visual on or off
        if (e.selectedCounter == baseCounter) {
            Show();
        } else {
            Hide();
        }
    }

    private void Show() {
        foreach (GameObject visualGameObject in visualGameObjectArray) {
            visualGameObject.SetActive(true);
        }
    }

    private void Hide() {
        foreach (GameObject visualGameObject in visualGameObjectArray) {
            visualGameObject.SetActive(false);
        }
    }
}

    