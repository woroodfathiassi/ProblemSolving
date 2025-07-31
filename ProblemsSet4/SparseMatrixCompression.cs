namespace ProblemsSet4;

public class SparseMatrixCompression
{
    public static CompressedMatrix Compress(int[][] arr)
    {
        var dict = new Dictionary<(int, int), int>();
        int rows = arr.Length;
        int cols = arr.Length > 0 ? arr[0].Length : 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                if (arr[i][j] != 0)
                    dict[(i, j)] = arr[i][j];
            }
        }

        return new CompressedMatrix
        {
            Data = dict,
            Rows = rows,
            Cols = cols
        };
    }

    public static int[][] Decompress(CompressedMatrix dict)
    {
        int[][] arr = new int[dict.Rows][];

        for(int i=0 ;  i < dict.Rows ; i++)
        {
            arr[i] = new int [dict.Cols];
        }

        foreach (var data in dict.Data)
        {
            var (i,j) = data.Key;
            arr[i][j] = data.Value;
        }
        return arr;
    }
}
