using System.Reflection;

namespace ProblemsSet4;

public static class ReflectionCloner
{
    public static T DeepClone<T>(T original)
    {
        var visited = new Dictionary<object, object>();
        return (T)CloneRecursive(original, visited);
    }

    private static object CloneRecursive(object original, Dictionary<object, object> visited)
    {
        if (original == null)
            return null;

        if (visited.TryGetValue(original, out object? value))
        {
            Console.WriteLine($"Reusing (reflection): {original}");
            return value;
        }

        Type type = original.GetType();

        if (type.IsPrimitive || type == typeof(string))
            return original;

        object clone = Activator.CreateInstance(type);
        visited[original] = clone;

        Console.WriteLine($"Cloning (reflection): {type.Name}");

        foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (!prop.CanWrite) continue;

            var originalValue = prop.GetValue(original);
            var clonedValue = CloneRecursive(originalValue, visited);
            prop.SetValue(clone, clonedValue);
        }

        return clone;
    }
}
