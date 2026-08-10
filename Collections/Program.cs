// See https://aka.ms/new-console-template for more information
using Collections;
List<int> ls = new List<int> { 1,2,3,4,5};
//List<int> ls2 = new List<int> { 1, 2, 3, 4, 5 };
//List<string> ls1 = new List<string> {"apple","banana","apple","banana"};
//RevList.ReverseList(ls);
//Console.WriteLine(string.Join(',', ls));
//FreqOfElements.FreqElements(ls1);
//RotateList.RotateeList(ls2,2);
//Console.WriteLine(string.Join(',', ls2));
List<int> res=RemoveDuplicate.RemoveeDuplicate(new List<int> { 1, 1, 2, 3, 5 });
Console.WriteLine(string.Join(',', res));
Console.WriteLine(NthElement.NElement(ls,2));
