public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int count = 0;
        
        while (encodedCount != 0)
        {
            if (encodedCount % 2 == 1) count++;
            encodedCount /= 2;
        }

        return count;
    }
}
