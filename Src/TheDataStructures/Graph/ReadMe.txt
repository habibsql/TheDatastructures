- A data structure that consists of a set of vertics(nodes) and a set of edges(relate nodes to each other)
- Set of edges describe the relasionship of nodes each other.
- G = (V,E)
    - V(G): a finite, non empty set of vertices
    - E(G): a set of edges (pairs of vertices)

-   V = {0, 1, 2, 3}
    E = {(0,1), (0,2), (0,3), (1,2)}
    G = {V, E}    

- Various types of graphs:
  - Weighted Graph ->  If Edges in the Graphs have values.
  - Directed Graph -> A graph with only directed edges.
  - Undirect Graph -> No direction, so it should be both direction.
  

- Real life Examples:
 - Social network : People are vertices (nodes). Their relationship like friends are edges.

 - Graph traversal methods
    - Breadth first
        - Use queue data strcuture to remember.
        - Visit the adjacent unvisited vertex. Mark it as visited. Display it. Push it in a queue.
        - If no adjacent vertex is found, remove the first vertex from the queue.
        - Repeat last 2 until stack is empty.
    - Depth first
        - Use stack to remember visited vertex.
        - Visit the adjacent unvisited vertex. Mark it as visited. Display it. Push it in a stack.
        - If no adjacent vertex is found, pop up a vertex from the stack.
        - Repeat last 2 until stack is empty.

 - Visiting a vertex : Going on a particular vertex.
 - Exploration of vertex : Visiting all its adjacent verteces.
 - Path: A sequece of edges that allows to go from vertex A to vertex B is called a path.
 - Adjacency: A vertix is said to be adjacent to another vertex if there is an edge connecting them.
 

 - Graph Representation:
    - Adjacency Matrix : 2D array of (n * n) vertices. Each row and column represent a vertex.
    - Adjacency List: Represetns a graph as an array of linked list 


- Graph Operations:
 - Graph Traversal
 - Add Elements (vertex, edges) to graph
 - Finding path from one vertex to another.
 - Check if element is present in the graph.
 - Display a vertex.