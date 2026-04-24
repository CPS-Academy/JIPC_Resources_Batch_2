#include<iostream>
#include<ctime>
using namespace std;

int partition(int arr[], int left, int right) {

    int randomIndex = left + rand()%(right - left + 1);

    swap(arr[randomIndex], arr[right]);
    int pivot = arr[right];

    int i = left - 1;
    for(int j = left; j < right; j++) {
        if(arr[j] <= pivot) {
            i++;
            swap(arr[i], arr[j]);
        }
    }

    swap(arr[i + 1], arr[right]);
    return i + 1;
}

void quickSort(int arr[], int left, int right) {

    if(left >= right) {
        return;
    }

    int pivotIndex = partition(arr, left, right);

    quickSort(arr, left, pivotIndex - 1);
    quickSort(arr, pivotIndex + 1, right);
}

int main()
{
    srand(time(0));

    int arr[100005], n;
    cin >> n;
    for(int i = 0; i < n; i++) {
        cin >> arr[i];
    }

    quickSort(arr, 0, n - 1);

    for(int i = 0; i < n; i++) {
        cout << arr[i] << ' ';
    }
    cout << '\n';

    return 0;
}
