using System.IO;
using System.Linq;

namespace Atlas
{
    internal sealed class LayerFileModificationProcessor : UnityEditor.AssetModificationProcessor
    {
        public static string[] OnWillSaveAssets( string[] assetPaths )
        {
            // regenerate layer file, but only if it already exists
            if ( assetPaths.Contains( c_layerAssetName ) &&
                 File.Exists( LayerFileGenerator.FullLayerFilePath ) )
            {
                LayerFileGenerator.Generate();
            }

            return assetPaths;
        }

        private const string c_layerAssetName = "ProjectSettings/TagManager.asset";
    }
}