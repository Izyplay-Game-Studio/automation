using UnityEditor;

namespace GameWorkstore.Automation
{
    public abstract class StandaloneBuildPlatform : BuildPlatform
    {
        public ScriptingImplementation ScriptingBackend = ScriptingImplementation.IL2CPP;
        public string[] AdditionalFolders = new string[0];
    }
}