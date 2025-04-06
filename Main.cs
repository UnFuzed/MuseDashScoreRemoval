using MelonLoader;
using UnityEngine;

namespace MuseDashScoreRemoval
{
    public class Main : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName != "UISystem_PC" && sceneName != "GameMain") return;

            List<string> objsToRemove = new() { "TxtValue", "GradeScale"};

            List<GameObject> allObjects = Resources.FindObjectsOfTypeAll<GameObject>().ToList();
            foreach (GameObject obj in allObjects)
            {
                if (objsToRemove.Contains(obj.name))
                    obj.SetActive(false);
            }
        }
    }
}
