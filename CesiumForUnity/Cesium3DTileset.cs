using Reinterop;
using UnityEngine;
using UnityEditor;

namespace CesiumForUnity
{

    [ExecuteInEditMode]
    [ReinteropNativeImplementation("CesiumForUnity::Cesium3DTilesetImpl", "Cesium3DTilesetImpl.h")]
    public partial class Cesium3DTileset : MonoBehaviour
    {
        [SerializeField]
        [Header("Cesium")]
        [Tooltip("The URL of this tileset's \"tileset.json\" file.")]
        [InspectorName("URL")]
        private string _url = "";

        public string url
        {
            get => this._url;
            set
            {
                this._url = value;
                this.RecreateTileset();
            }
        }

        [SerializeField]
        [Tooltip("The ID of the Cesium ion asset to use.")]
        [InspectorName("ion Asset ID")]
        private ulong _ionAssetID = 0;

        public ulong ionAssetID
        {
            get => this._ionAssetID;
            set
            {
                this._ionAssetID = value;
                this.RecreateTileset();
            }
        }

        [SerializeField]
        [Tooltip("The access token to use to access the Cesium ion resource.")]
        [InspectorName("ion Access Token")]
        public string _ionAccessToken = "";

        public string ionAccessToken
        {
            get => this._ionAccessToken;
            set
            {
                this._ionAccessToken = value;
                this.RecreateTileset();
            }
        }

        private partial void Start();
        private partial void Update();
        private partial void OnValidate();

        private void OnEnable()
        {
            // In the Editor, Update will only be called when something
            // changes. We need to call it continuously to allow tiles to
            // load.
            // TODO: we could be more careful about only calling Update when
            //       it's really needed.
            if (Application.isEditor && !EditorApplication.isPlaying)
            {
                EditorApplication.update += Update;
            }
        }

        private void OnDisable()
        {
            EditorApplication.update -= Update;
        }

        private partial void RecreateTileset();
    }
}
