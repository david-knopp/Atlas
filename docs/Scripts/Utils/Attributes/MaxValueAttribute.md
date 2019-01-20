# MaxValueAttribute
## Description
Sets a maximum value for the given field, preventing assigning a value greater than the specified value when editing the field in the inspector window.

```csharp
using Atlas;
using UnityEngine;

public class Example : MonoBehaviour
{
    [MaxValue( 10.0f )] public float m_value;
}
```
<aside class="warning">
Note: This Attribute does **not** apply the maximum value restriction when the field is changed through code, it only applies when editing through the inspector.
</aside>

------------
See also: [MinValueAttribute](MinValueAttribute.md)