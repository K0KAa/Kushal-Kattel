class Array
{
    void Learn1DArray()
    {
        int[] ages =new int[10];
        double[] age1 = new double[10];

        ages[0] = 14;

        float[] numbers = new float[] {23.4f, 32.5f, 1.1f};
        float[] number = {23.4f, 32.5f, 1.1f};
    }

    void LearnMultiArray()
    {
        int[,] agesMatrix = new int[10,15];
        agesMatrix[0,0] = 453;
        int[, ,] agesMatrix3D = new int [4,4,4];

        string[,] names = new string [,] { {"Kushal", "Kamal"}, {"Ram", "Shyam"}};

    }

    void LearnJaggedArray()
    {
        byte[][] personAges = new byte[3][];
        personAges[0] = new byte[] {34,54};
        personAges[1] = new byte[] {45,56,78,9};
        personAges[2] = new byte[] {3,45,6,23,121,12};
    }
}