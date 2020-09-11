* Heap is a special kind of binary tree data strcuture. It is non linear, hierarchycal data strcuture.

2 types of Heap exists:
1) Max Heap
    - Parent Node is always maximum value of its chidren.
2) Min Heap
    - Parent Node is always smaller value of its children.

Its properties are:
1) If it is Min heap -> Value of each node or child is >= its parent value.
2) Root node will be the minimum value
3) If it is Max heap -> Value of each node or child is < its parent value
4) Root node will be the maximum value.
5) All level of heap tree should be full except leaf node
6) Nodes must be filled from left->right direction.


Time Complexity:
Insert -> O(log n)
Delete -> O(Log n)
Find Minimum/Maximim values -> O(1)
Search -> Search an item is not recommended here. Its time complexity will be O(n)