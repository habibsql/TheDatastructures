- Self Balancing Binary Search Tree (BST)
- Difference between left subtree and right subtree cannot be more then one for all nodes.


- Purpose:
	- Most BST operations time complexity O(h). That problem is soved here.


- Operations:
  - Balance factor calculation: Hight of left subtree - hight of right subtree should be  0, 1, -1 
  - Insert: After every insert need to check balance factor of each nodes and make tree balace again.
  - Delete: Delete is same as BST. After delete need to check the balance factor of each node again and make tree need to balanced.