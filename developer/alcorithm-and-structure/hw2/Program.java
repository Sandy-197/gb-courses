// Связный список разворот
public class Nodes {

    private static class Node {
        Node next;
        int value;
    }

    Node head;

    public void addToHead(int value) {
        Node newNode = new Node();
        newNode.value = value;
        if (head != null)
            newNode.next = head;
        head = newNode;
    }

    public void removeFromHead() {
        if (head != null) {
            head = head.next;
        }
    }

    public boolean findValueInNodes(int value) {
        Node currNode = head;
        while (currNode != null) {
            if (currNode.value == value)
                return true;
            currNode = currNode.next;
        }
        return false;
    }

    public void addToTail(int value) {
        Node newNode = new Node();
        newNode.value = value;
        if (head == null)
            head = node;
        else {
            Node lastNode = head;
            while (lastNode.next != null) {
                lastNode = lastNode.next;
            }
            lastNode.next = newNode;
        }
    }

    public void removeFromTail() {
        if (head != null) {
            Node preTailNode = head;
            while (preTailNode.next != null) {
                if (preTailNode.next.next == null) {
                    preTailNode.next = null;
                    return;
                }
                preTailNode = preTailNode.next;
            }
            head = null;
        }
    }

    public void reversNodes() {
        if (head != null && head.next != null)
            reversNodes(head.next, head);
    }

    private void reversNodes(Node currNode, Node prevNode) {
        if (currNode.next == null) {
            head = currNode;
        } else {
            reversNodes(currNode.next, currNode);
        }
        currNode.next = prevNode;
        prevNode.next = null;
    }
}
