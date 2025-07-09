using UnityEditor;
using UnityEngine;

public class AnimationInspector : EditorWindow
{
    private AnimationClip animationClip;
    private int frameToCheck;
    private string animationInfo;

    [MenuItem("Window/Animation Inspector")]
    public static void ShowWindow()
    {
        GetWindow<AnimationInspector>("Animation Inspector");
    }

    private void OnGUI() 
    {
        animationClip = (AnimationClip)EditorGUILayout.ObjectField("Animation Clip", animationClip, typeof(AnimationClip), false);
        frameToCheck = EditorGUILayout.IntField(frameToCheck);
        animationInfo = EditorGUILayout.TextArea(animationInfo, GUILayout.Height(100));

        if (!animationClip)
        {
            animationInfo = "There is no animation clip to inspect";
            return;
        }

        if (GUILayout.Button("Get Animation Info"))
        {
            float length = animationClip.length;
            string lengthInfo = "Length: " + length;

            int frames = Mathf.RoundToInt(animationClip.frameRate * length);
            string framesInfo = "Frames: " + frames;

            float frameLenght = length / frames;
            float frameTime = frameToCheck * frameLenght;
            string frameTimeInfo = "Frame Time: " + frameTime;

            float normalizedTriggerTime = (float) frameToCheck / frames;
            string normalizedTriggerTimeInfo = "Normalized Frame Time: " + normalizedTriggerTime;

            animationInfo = lengthInfo + "\n" + framesInfo + "\n" + frameTimeInfo + "\n" + normalizedTriggerTimeInfo;
        }
    }
}
