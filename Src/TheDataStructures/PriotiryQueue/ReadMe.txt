- Abstract Data type (ADT)
- Similar to regular Queue just contain additional priority value of each item.
- High priority item is served before low priority item.
- 2 types of priority queue i) Max ii) Min
- Implement priority queue using Binary Heap data structure.
- If 2 items have same priority they are served according to their order in the queue.
- Priority queue can implemented using Array or Heap. Heap is recommended approach.


- Operations:
	- Is Empty
	- Insert With Priority
	- Pull Hightest Priority Element
	- Delete Hightest Priority Element


- Performance:
	- GetHighestPriority() -> O(1)
	- DeleteHightestPriority() -> O(Logn)

- Applicaiton:
	- Operating System Scheduling
	- Various Graph Algorithm Dijkstra's shortest path, Prims minium spanning tree
	- All queue application where priority is envolved.