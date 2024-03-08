   public class IvyProfileAsset : ScriptableObject
    { 
        #if UNITY_EDITOR
        public IvyProfile ivyProfile;

        [ContextMenu("Reset to Default Ivy Settings")]
        public void ResetProfile() {
            ivyProfile.ResetSettings();
            this.SetDirty();
        }
        #endif
    }
//yes
public class ObjExport
	{
		private static int StartIndex = 0;
		
		public static string MeshToString(MeshFilter mf, Transform t) 
		{	
			int numVertices = 0;
			Mesh m = mf.sharedMesh;
			if (!m)
			{
				return "####Error####";
			}
			Material[] mats = mf.GetComponent<Renderer>().sharedMaterials;
			
			StringBuilder sb = new StringBuilder();
			
			foreach(Vector3 vv in m.vertices)
			{
//good
