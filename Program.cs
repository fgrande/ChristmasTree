DrawTree(15);


static void DrawTree(int depth)
{
    // Draw the Tree
    int i = 0;
    while (i < depth)
    {
        i++;
        int stars = (i * 2) - 1;
        int spaces = depth - i;

        string spacesStr = new(' ', spaces);
        string starsStr = new('*', stars);

        Console.WriteLine(spacesStr + starsStr);
    }

    // Calculate the trunk dimension adapting it to the tree's size
    int trunkWidth = ((depth / 5) * 2) - 1;
    if (trunkWidth <= 0)
    {
        trunkWidth = 1;
    }

    // Trunk height is proportional to trunk width
    int trunkHeight = (int)Math.Round(trunkWidth * 1.5, 0);

    // Draw the Trunk
    int trunkSpaces = (((depth * 2) - 1) - trunkWidth) / 2;
    string trunkSpacesStr = new(' ', trunkSpaces);
    string trunkStarsStr = new('*', trunkWidth);
    for (int r = 0; r < trunkHeight; r++)
    {
        Console.WriteLine(trunkSpacesStr + trunkStarsStr);
    }
}