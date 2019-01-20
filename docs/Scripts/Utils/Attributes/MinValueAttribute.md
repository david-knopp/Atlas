# MinValueAttribute
## Description
Sets a minimum value for the given field, preventing assigning a value less than the specified value when editing the field in the inspector window.

```csharp
using Atlas;
using UnityEngine;

public class Example : MonoBehaviour
{
    [MinValue( 0.0f )] public float m_value;
}
```
<aside class="warning">
Note: This Attribute does **not** apply the minimum value restriction when the field is changed through code, it only applies when editing through the inspector.
</aside>

------------
See also: [MaxValueAttribute](MaxValueAttribute.md)