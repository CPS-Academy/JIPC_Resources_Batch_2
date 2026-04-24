#include<iostream>
using namespace std;

void merge(int arr[], int left, int mid, int right) {

    int n1 = mid - left + 1; // size of left partition
    int n2 = right - mid; // size of right partition

    int L[n1], R[n2];
    for(int i = 0, j = left; i < n1; i++, j++) {
        L[i] = arr[j];
    }
    for(int i = 0, j = mid + 1; i < n2; i++, j++) {
        R[i] = arr[j];
    }

    int i = 0, j = 0, k = left;
    while(i < n1 && j < n2) {
        if(L[i] < R[j]) {
            arr[k] = L[i];
            i++;
        }
        else {
            arr[k] = R[j];
            j++;
        }
        k++;
    }

    while(i < n1) {
        arr[k] = L[i];
        i++; k++;
    }

    while(j < n2) {
        arr[k] = R[j];
        j++; k++;
    }
}

void mergeSort(int arr[], int left, int right) {

    if(left >= right) { // invalid range
        return;
    }

    int mid = left + (right - left)/2;
    mergeSort(arr, left, mid);  // left sub range
    mergeSort(arr, mid + 1, right); // right sub range

    merge(arr, left, mid, right); // merge two sorted array
}

int main()
{
    int arr[100005], n;
    cin >> n;
    for(int i = 0; i < n; i++) {
        cin >> arr[i];
    }

    mergeSort(arr, 0, n - 1);

    for(int i = 0; i < n; i++) {
        cout << arr[i] << ' ';
    }
    cout << '\n';

    return 0;
}

/*


*/
