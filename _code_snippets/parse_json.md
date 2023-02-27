

```
using System.Text.Json.Nodes;

query = JsonNode.Parse(query)?.ToJsonString(new System.Text.Json.JsonSerializerOptions() { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

```