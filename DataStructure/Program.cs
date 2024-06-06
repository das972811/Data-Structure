using DataStructure.LinkedList;

// See https://aka.ms/new-console-template for more information
SinglyLinkedList linkedList = new();
linkedList.AddAtHead(0);
linkedList.AddAtHead(2);
linkedList.AddAtTail(1);
linkedList.AddAtTail(3);
linkedList.AddAtIndex(2, 400);
linkedList.DeleteAtIndex(4);

Console.WriteLine(linkedList.Get(0));
Console.WriteLine(linkedList.Get(1));
