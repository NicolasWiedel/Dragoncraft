using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Dragoncraft
{
    [CustomEditor(typeof(LevelData))]
    public class LevelDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            LevelData levelData = (LevelData) target;
            AddLevelDetails(levelData);
            AddLevelSlot(levelData);
            AddButtonInitialize(levelData);
            AddButtomUpdate(levelData);
        }
    }
}


