
# 🔢 Sorting Algorithms: Bubble Sort vs QuickSort

## 🟡 Bubble Sort (Step-by-Step)

Bubble Sort repeatedly compares and swaps adjacent elements if they are in the wrong order.

### Example: [20, 30, 10, 40]

#### ✅ Pass 1:
| Step | Compared      | Swap?    | Result             |
|------|---------------|----------|--------------------|
| 1    | 20 & 30       | ❌ No     | [20, 30, 10, 40]   |
| 2    | 30 & 10       | ✅ Yes    | [20, 10, 30, 40]   |
| 3    | 30 & 40       | ❌ No     | [20, 10, 30, 40]   |

#### ✅ Pass 2:
| Step | Compared      | Swap?    | Result             |
|------|---------------|----------|--------------------|
| 1    | 20 & 10       | ✅ Yes    | [10, 20, 30, 40]   |
| 2    | 20 & 30       | ❌ No     | [10, 20, 30, 40]   |
| 3    | 30 & 40       | ❌ No     | [10, 20, 30, 40]   |

#### ✅ Pass 3:
No swaps needed — list is sorted.

### 🧾 Final Result: [10, 20, 30, 40]

---

## 🔷 QuickSort (Using First Element as Pivot)

QuickSort uses **divide-and-conquer** by selecting a pivot and partitioning the list into left and right sublists.

### Example: [50, 10, 30, 20, 40]

#### ✅ Step 1 – Pick Pivot (30)
- Left: [10, 20]
- Pivot: 30
- Right: [50, 40]

#### ✅ Step 2 – Sort Left: [10, 20]
- Pivot: 10 (first element)
- Compare: 20 > 10 → goes to right
- ✅ Sorted Left: [10, 20]

#### ✅ Step 3 – Sort Right: [50, 40]
- Pivot: 50 (first element)
- Compare: 40 < 50 → goes to left
- ✅ Sorted Right: [40, 50]

#### ✅ Final Merge:
- Left: [10, 20]
- Pivot: [30]
- Right: [40, 50]

### 🧾 Final Result: [10, 20, 30, 40, 50]

---

## 🔍 Comparison Summary

| Feature          | Bubble Sort           | QuickSort                     |
|------------------|------------------------|-------------------------------|
| Strategy         | Swap adjacent elements | Divide and conquer            |
| Time Complexity  | O(n²)                  | O(n log n) average case       |
| Performance      | Slower                 | Much faster for large data    |
| Code Simplicity  | Very easy              | Slightly more complex         |
