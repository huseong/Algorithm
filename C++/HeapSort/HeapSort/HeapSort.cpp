// HeapSort.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

void pushHeap(int* arr, int key, int value);
int removeHeap(int* arr, int len);
void printHeap(int* arr, int length);

int _tmain(int argc, _TCHAR* argv[])
{
	int* arr = new int;
	//cout << (arr[1] == *(arr + 1)) << endl;
	int count = 1;
	while (true) {
		string s;
		cin >> s;
		if (s == "0")
		{
			cout << "Input End" << endl;
			break;
		}
		pushHeap(arr, count++, stoi(s));
	}
	count -= 1;
	cout << "Now, Heap is made with your inputvalues. Let's see it" << endl;
	printHeap(arr, count);
	cout << "This is our Heap. Now, let's sort it" << endl;
	while (count>1) 
	{
		printHeap(arr, count);
		cout << removeHeap(arr, count--) << endl;
	}
	return 0;
}

void pushHeap(int* arr, int key, int value) {
	arr[key] = value;
	while (key > 0) {
		if (arr[key] < arr[key / 2]) { // minHeapSort
			swap(arr[key], arr[key / 2]);
			key /= 2;
		}
		else {
			break;
		}
	}
}

void printHeap(int* arr, int length) {
	cout << "[";
	for (int i = 1; i < length; i++) {
		cout << arr[i] << ", ";
	}
	cout << arr[length] << "]" << endl;
}

int removeHeap(int* arr, int len) {
	int returnvalue = arr[1];
	arr[1] = arr[len];
	len -= 1;
	int key = 1;
	while (key * 2 < len) {
		if (arr[key] > arr[key * 2]) {
			if (arr[key] > arr[key * 2 + 1]) {
				if (arr[key * 2] >= arr[key * 2 + 1]) {
					swap(arr[key * 2 + 1], arr[key]);
					key = key * 2 + 1;
				}
				else {
					swap(arr[key * 2], arr[key]);
					key *= 2;
				}
            }
			else {
				swap(arr[key * 2], arr[key]);
				key *= 2;
			}
		}
		else if (arr[key] > arr[key * 2 + 1]) {
			swap(arr[key * 2 + 1], arr[key]);
			key = key * 2 + 1;
		}
		else {
			break;
		}
	}
	return returnvalue;
}



