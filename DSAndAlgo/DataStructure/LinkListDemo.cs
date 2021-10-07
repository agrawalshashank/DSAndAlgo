using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.SimpleLinkedList;

namespace DSAndAlgo.DataStructure
{
    public class LinkListDemo
    {
        public void SimpleLinkedList()
        {
            SimpleLinkList<string> simpleLinkList = new SimpleLinkList<string>();
            simpleLinkList.AddLastWithOptimization("One");
            simpleLinkList.AddLastWithOptimization("two");
            simpleLinkList.AddLastWithOptimization("Three");
            simpleLinkList.AddLastWithOptimization("Four");

            simpleLinkList.AddFirst("First Item");

            simpleLinkList.ReadAll();
        }
    }
}
