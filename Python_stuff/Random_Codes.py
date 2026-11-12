# MergeSort

def break_it_down(arr):
    if len(arr) <= 1:
        return arr
    mid = len(arr) // 2
    left_half = break_it_down(arr[:mid])
    right_half = break_it_down(arr[mid:])
    return merge(left_half, right_half)

def merge(left, right):
    merged_version = []
    x = y = 0
    while x < len(left) and y < len(right):
        if left[x] < right[y]:
            merged_version.append(left[x])
            x += 1
        else:
            merged_version.append(right[y])
            y += 1
    merged_version.extend(left[x:])
    merged_version.extend(right[y:])
    return merged_version

if __name__ == "__main__":
    arr = [38, 27, 43, 3, 9, 82, 10]
    print("Original array:", arr)
    sorted_arr = break_it_down(arr)
    print("\nSorted array:", sorted_arr)


# QuickSort

def quick_sort(arr,low,high):
    kingpin = arr[high]
    i = low - 1
    for j in range(low, high):
        if arr[j] <= kingpin:
            i += 1
            swap(arr, i, j)
    swap(arr, i + 1, high)
    return i + 1

def swap(arr, i, j):
    arr[i], arr[j] = arr[j], arr[i] 

if __name__ == "__main__":
    arr = [10, 7, 8, 9, 1, 5]
    n = len(arr)
    print("Original array:", arr)
    quick_sort(arr, 0, n - 1)
    print("\nSorted array:", arr)