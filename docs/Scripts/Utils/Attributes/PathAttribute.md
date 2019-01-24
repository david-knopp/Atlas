# PathAttribute
## Description
Marks the given `string` field as a folder path, and automatically provides a button next to the field in the inspector that opens your system's folder browser.

![PathAttribute inspector preview](Media/PathAttribute.gif)

```csharp
using Atlas;
using UnityEngine;
using PathType = Atlas.PathAttribute.PathType;

public class Example : MonoBehaviour
{
    [Path( PathType.ProjectRelative )] public string m_path;
}
```

------------
See also: [ScenePathAttribute](ScenePathAttribute.md)