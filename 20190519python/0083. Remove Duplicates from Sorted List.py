# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def deleteDuplicates(self, head: ListNode) -> ListNode:
        if not head or not head.next:
            return head
        
        node=ListNode(0)
        node.next=head
        p=node
        
        while p.next and p.next.next:
            if p.next.val==p.next.next.val:
                p.next=p.next.next
            else:
                p=p.next
        return node.next
        
