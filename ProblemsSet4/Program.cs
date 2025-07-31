using ProblemsSet4;

#region CompressedMatrix
int[][] originalArray = {
    [0, 0, 5],
    [0, 0, 0],
    [2, 0, 0]
};

var compressed = SparseMatrixCompression.Compress(originalArray);
Console.WriteLine("Compressed Dictionary:");
foreach (var kvp in compressed.Data)
{
    Console.WriteLine($"({kvp.Key.Item1}, {kvp.Key.Item2}) -> {kvp.Value}");
}

var decompressed = SparseMatrixCompression.Decompress(compressed);
Console.WriteLine("\nDecompressed Matrix:");
for (int i = 0; i < decompressed.Length; i++)
{
    for (int j = 0; j < decompressed[i].Length; j++)
    {
        Console.Write(decompressed[i][j] + " ");
    }
    Console.WriteLine();
}

#endregion

#region Password Pattern Generator

PasswordPatternGenerator.GeneratePasswords("sA#d");

#endregion

#region Deep Object Cloner

Person a = new() { Name = "Ahmad" };
Person b = new() { Name = "Sara" };
a.Friend = b;
b.Friend = a;

Console.WriteLine("\n\nStarting deep clone using reflection...\n");

// Clone using ReflectionCloner
Person clone = ReflectionCloner.DeepClone(a);
//Person clone = a;
Console.WriteLine($"Clone Name: {clone.Name}");

clone.Name = "Worood";
clone.Friend.Name = "Assi";

Console.WriteLine("\nClone result:");
Console.WriteLine($"Clone Name: {clone.Name}");
Console.WriteLine($"a Name: {a.Name}");

Console.WriteLine($"Clone Friend: {clone.Friend?.Name}");
Console.WriteLine($"a Friend: {a.Friend?.Name}");

Console.WriteLine($"Clone Friend's Friend: {clone.Friend?.Friend?.Name}");
Console.WriteLine($"a Friend's Friend: {a.Friend?.Friend?.Name}");


#endregion