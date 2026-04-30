using GraphProject;

///Задание 1
//Graph<string> graph = new Graph<string>(true, true);
//Node<string> A = graph.AddNode("A");
//Node<string> B = graph.AddNode("B");
//Node<string> C = graph.AddNode("C");
//Node<string> D = graph.AddNode("D");
//Node<string> E = graph.AddNode("E");
//Node<string> F = graph.AddNode("F");
//Node<string> G = graph.AddNode("G");
//Node<string> H = graph.AddNode("H");

//graph.AddEdge(A, B);
//graph.AddEdge(A, E);
//graph.AddEdge(A, F);
//graph.AddEdge(B, C);
//graph.AddEdge(B, D);
//graph.AddEdge(D, H);
//graph.AddEdge(D, E);
//graph.AddEdge(E, F);
//graph.AddEdge(H, G);

//List<Node<string>> dfsnodes = graph.DFS();
//dfsnodes.ForEach(n => Console.WriteLine(n));
//Console.WriteLine();

//Задание 2

Graph<string> graph = new Graph<string>(true, true);
Node<string> A = graph.AddNode("A");
Node<string> B = graph.AddNode("B");
Node<string> C = graph.AddNode("C");
Node<string> D = graph.AddNode("D");
Node<string> E = graph.AddNode("E");
Node<string> F = graph.AddNode("F");
Node<string> G = graph.AddNode("G");
Node<string> H = graph.AddNode("H");

graph.AddEdge(A, G);
graph.AddEdge(B, C);
graph.AddEdge(B, D);
graph.AddEdge(D, H);
graph.AddEdge(D, G);
graph.AddEdge(E, D);
graph.AddEdge(E, B);
graph.AddEdge(F, E);
graph.AddEdge(F, C);
graph.AddEdge(G, F);

List<Node<string>> dfsnodes = graph.BFS();
dfsnodes.ForEach(n => Console.WriteLine(n));
Console.WriteLine();