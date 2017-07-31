int adjacentElementsProduct(int[] inputArray) {
    int i = inputArray.Length - 1;
    int[] products = new int[i];
    int n = 0;
    int x = 0;
    int y = x + 1;
    while(y < inputArray.Length)
    {
        products[n] = inputArray[x] * inputArray[y];
        ++n;
        ++x;
        ++y;
    }
    return products.Max();
}