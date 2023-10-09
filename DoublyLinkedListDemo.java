import java.util.Scanner;

class Node {
    int data;
    Node prev;
    Node next;

    public Node(int data) {
        this.data = data;
        this.prev = null;
        this.next = null;
    }
}

class DoublyLinkedList {
    private Node head;
    private Node tail;
    private int count;

    //case 1
    public DoublyLinkedList() {
        head = null;
        tail = null;
        count = 0;
    }

    //case 2
    public boolean isEmpty() {
        return count == 0;
    }

    //case 3
    public int getLength() {
        return count;
    }

    //case 4 (display)
    public void printList(boolean reverse) {
    if (isEmpty()) {
        System.out.println("The list is empty.");
        return;
    }
    
    Node current = reverse ? tail : head;

    while (current != null) {
        System.out.print(current.data + " ");
        current = reverse ? current.prev : current.next;
    }
    System.out.println();
    }

    //case 5
    public boolean search(int item) {
        Node current = head;

        while (current != null) {
            if (current.data == item) {
                return true;
            }
            current = current.next;
        }
        return false;
    }

    //case 6
    public int front() {
        if (!isEmpty()) {
            return head.data;
        } else {
            System.out.println("The list is empty.");
            return -1; // Return -1 to indicate an empty list
        }
    }

    //case 7
    public int back() {
        if (!isEmpty()) {
            return tail.data;
        } else {
            System.out.println("The list is empty.");
            return -1; // Return -1 to indicate an empty list
        }
    }

    //case 8
    public void insert(int item) {
        Node newNode = new Node(item);

        if (isEmpty()) {
            head = newNode;
            tail = newNode;
        } else {
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
        count++;
    }

    //case 9
    public void delete(int item) {
    if (isEmpty()) {
        System.out.println("List is empty.");
        return;
    }

    Node current = head;
    boolean found = false;

    while (current != null) {
        if (current.data == item) {
            found = true;
            if (current.prev != null) {
                current.prev.next = current.next;
            } else {
                head = current.next;
            }

            if (current.next != null) {
                current.next.prev = current.prev;
            } else {
                tail = current.prev;
            }

            count--;
        }
        current = current.next;
    }

    if (found) {
        System.out.println("Item deleted.");
    } else {
        System.out.println("Item not found in the list.");
    }
}

}

public class DoublyLinkedListDemo {
    public static void main(String[] args) {
        DoublyLinkedList list = new DoublyLinkedList();
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("\nDoubly Linked List Operations:");
            System.out.println("1. Initialize the list");
            System.out.println("2. Determine whether the list is empty");
            System.out.println("3. Find the length of the list");
            System.out.println("4. Output the list");
            System.out.println("5. Search the list for a given item");
            System.out.println("6. Retrieve the first element of the list");
            System.out.println("7. Retrieve the last element of the list");
            System.out.println("8. Insert an item in the list");
            System.out.println("9. Delete an item from the list");
            System.out.println("0. Exit");
            System.out.print("Enter your choice: ");

            int choice = scanner.nextInt();

            switch (choice) {
                case 1:
                    if (!list.isEmpty()) {
                        list = new DoublyLinkedList();
                        System.out.println("List initialized.");
                        } else {
                            System.out.println("The list is already empty.");
                        }
                    break;
                case 2:
                    System.out.println("Is the list empty? " + list.isEmpty());
                    break;
                case 3:
                    System.out.println("Length of the list: " + list.getLength());
                    break;
                case 4:
                    System.out.print("Enter 1 for Forward Doubly Linked List or 2 for Reverse Doubly Linked List: ");
                    int orderChoice = scanner.nextInt();

                    if (orderChoice == 1) {
                        System.out.println("Forward Doubly Linked List:");
                        list.printList(false);
                    } else if (orderChoice == 2) {
                        System.out.println("Reverse Doubly Linked List:");
                        list.printList(true);
                    } else {
                        System.out.println("Invalid option. Please enter 1 for Forward Doubly Linked List or 2 for Reverse Doubly Linked List.");
                    }
                    break;
                case 5:
                    System.out.print("Enter item to search: ");
                    int searchItem = scanner.nextInt();
                    System.out.println("Item found in the list: " + list.search(searchItem));
                    break;
                case 6:
                    System.out.println("Front element of the list: " + list.front());
                    break;
                case 7:
                    System.out.println("Back element of the list: " + list.back());
                    break;
                case 8:
                    System.out.print("Enter an element to insert: ");
                    int itemToInsert = scanner.nextInt();
                    list.insert(itemToInsert);
                    System.out.println(itemToInsert + " inserted into the list.");
                    break;
                case 9:
                    System.out.print("Enter item to delete: ");
                    int deleteItem = scanner.nextInt();
                    list.delete(deleteItem);
                    System.out.println("Item deleted.");
                    break;
                case 0:
                    scanner.close();
                    System.exit(0);
                default:
                    System.out.println("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}