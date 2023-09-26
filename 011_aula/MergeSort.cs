
public class MergeSort : IOrdenacao
{
    public void Sort(List<string> list)
    {
        {
        MergeSortRecursive(list, 0, list.Count - 1);
    }
    }

    private void MergeSortRecursive(List<string> lista, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortRecursive(lista, left, mid);
            MergeSortRecursive(lista, mid + 1, right);
            Merge(lista, left, mid, right);
        }
    }

    private void Merge(List<string> lista, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        List<string> leftArray = new List<string>();
        List<string> rightArray = new List<string>();

        for (int i = 0; i < n1; i++)
        {
            leftArray.Add(lista[left + i]);
        }

        for (int i = 0; i < n2; i++)
        {
            rightArray.Add(lista[mid + 1 + i]);
        }

        int j = 0;
        int k = 0;
        int index = left;

        while (j < n1 && k < n2)
        {
            if (string.Compare(leftArray[j], rightArray[k]) <= 0)
            {
                lista[index] = leftArray[j];
                j++;
            }
            else
            {
                lista[index] = rightArray[k];
                k++;
            }
            index++;
        }

        while (j < n1)
        {
            lista[index] = leftArray[j];
            j++;
            index++;
        }

        while (k < n2)
        {
            lista[index] = rightArray[k];
            k++;
            index++;
        }
    }
}