int makeArrayConsecutive2(int[] statues) {
    for (int i = 0; i < statues.Length; i++)
    {
        bool ocorreuTroca = false;
        for (int j = 1; j < statues.Length - i; j++)
        {
            if (statues[j - 1] > statues[j])
            {
                //Troca
                ocorreuTroca = true;
                int aux = statues[j];
                statues[j] = statues[j - 1];
                statues[j - 1] = aux;
            }
            if (ocorreuTroca == false)
                break;
        }
    }
    
    for (int x = 0; x < statues.Length; ++x)
    {
        if (statues[x]+1 < statues[x+1])
            
    }
}