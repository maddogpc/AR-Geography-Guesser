using UnityEngine;

namespace WPM {

    public interface IInputProxy {

        bool GetButtonDown(string buttonName);
        bool GetButtonUp(string buttonName);
        bool GetMouseButton(int buttonIndex);
        bool GetMouseButtonDown(int buttonIndex);
        bool GetMouseButtonUp(int buttonIndex);
        Vector3 mousePosition { get; }
        bool touchSupported { get; }
        int touchCount { get; }
        bool GetKey(string name);
        bool GetKey(KeyCode keyCode);
        bool GetKeyDown(KeyCode keyCode);
        Touch GetTouch(int index);
        float GetAxis(string axisName);
        Touch[] touches { get; }
        LocationService location { get; }
    }

}