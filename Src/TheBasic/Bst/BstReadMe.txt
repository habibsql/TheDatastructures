Bst -> Binary Search Tree

A special Kind of binary tree which properties are

1) Every Node at most 2 child node.
2) It is okay if 0 or 1 child node exists.
3) Left child node should contain less than or equal of its parents node value (considering subtree)
4) Right child node should contain greater than of its parents value (considering subtree).

The time complexity of BST
Worst case:
* Searching/Insertion/Deletion : O(h)  -> h is the height of the tree
* Height = no of edges from root node to its deepest leaf node.


2 types of tree traversals are there:
1) Dept First
    i) Inorder = Left->Root->Right
    ii) PreOrder = Root->Left->Right
    iii) PostOrder = Left->Right->Root

2) Breath First
     Need to take help from Queue or Stack when traversal process.