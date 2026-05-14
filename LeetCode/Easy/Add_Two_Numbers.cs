namespace LeetCode.Easy;

public class Add_Two_Numbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        int carry = 0;
        // l1 = [2,4,3], l2 = [5,6,4]

        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = carry; // 7

            if (l1 != null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            // sum here will be 7

            carry = sum / 10; // 0
            current.next = new ListNode(sum % 10); // 3
            current = current.next;
        }
        return dummy.next;
    }
}