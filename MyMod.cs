
using Il2Cpp;
using Il2CppDecaGames.RotMG.Managers;
using Il2CppSystem;
using MelonLoader;
using UnityEngine;
using Object = UnityEngine.Object;


#nullable enable
namespace BasicMelonMod
{
    public class ANTICHEAT : MelonMod
    {
        public static ANTICHEAT? instance;
        private GameObject? GameControllerObj;
        private ApplicationManager? ApplicationManagerObj;
        private GameObject? AntiCheatToolkitObj;
        private OIGNDMLLBGC? sceneInformation;
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName != "Main")
                return;
            this.Setup();
        }

        private void Setup()
        {
            this.GameControllerObj = GameObject.Find("GameController");
            if (this.GameControllerObj == null
)
            {
                MelonLogger.Msg("ERROR: Failed to find GameController object.");
            }
            else
            {
                MelonLogger.Msg("SUCCESS: Found GameController Object");
                this.ApplicationManagerObj = this.GameControllerObj.GetComponent<ApplicationManager>();
                if (this.GameControllerObj == null
)
                {
                    MelonLogger.Msg("ERROR: Failed to find ApplicationManager object.");
                }
                else
                {
                    MelonLogger.Msg("SUCCESS: Found ApplicationManager object.");
                    this.AntiCheatToolkitObj = GameObject.Find("Anti-Cheat Toolkit");
                    if (this.GameControllerObj == null
)
                    {
                        MelonLogger.Msg("ERROR: Failed to find AntiCheatManager object.");
                    }
                    else
                    {
                        MelonLogger.Msg("SUCCESS: Found AntiCheatManager object - disabling.");
                        Object.Destroy(this.AntiCheatToolkitObj);
                        this.sceneInformation = this.ApplicationManagerObj._KKBAJFABEKE_k__BackingField;
                        if (this.sceneInformation == null)
                            MelonLogger.Msg("ERROR: Failed to find sceneInformation.");
                        else
                            MelonLogger.Msg("SUCCESS: Found sceneInformation.");
                    }
                }
            }
        }
    }
}
