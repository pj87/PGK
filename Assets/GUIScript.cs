using UnityEngine; 
using System.Collections; 

public class GUIScript : MonoBehaviour { 
    public GUIStyle style; 
    int life=123; 
    void OnGUI() 
    { 
        GUILayout.BeginArea(new Rect(Screen.width-200, 0, 5000, 500)); 
        //Tutaj można sobie forem wyświetlać jakieś fajne listy 
        //GUILayout.BeginVertical 
        GUILayout.Label("ŻYCIE: " + life, style); 
        //Z boku pasek do przewijania 
        //GUILayout.BeginScrollView 
        GUILayout.EndArea(); 
    } 
} 
