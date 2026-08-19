//You are given the root of a binary search tree (BST) and an integer val.
//Find the node in the BST that the node's value equals val
//return the subtree rooted with that node.
//If such a node does not exist, return null.

//Tree characteristics:
//Root -> Only node where Parent == null;
//Leaf -> Any node where Children == null;
//Depth -> How many nodes current node is from root;

using Assignment7._3._1;

//Initializing and populating tree
BinarySearchTree<int> tree = new();

tree.Insert(25);
tree.Insert(17);
tree.Insert(60);
tree.Insert(2);
tree.Insert(180);
tree.Insert(67);
tree.Insert(98);
tree.Insert(5);
tree.Insert(18);
tree.Insert(73);
tree.Insert(33);
tree.Insert(99);
tree.Insert(182);
tree.Insert(1);

//Visualizing tree (list style)
tree.InOrderTraversal();

//Visualizing tree (tree style)
tree.PrintTree();

tree.Find(2);