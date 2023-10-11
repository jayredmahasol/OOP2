import java.util.Scanner;

public class BookArray {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        Book[] books = new Book[10];

        for (int i = 0; i < 5; i++) {
            System.out.print("Enter the title of a fiction book: ");
            String fictionTitle = console.nextLine();
            books[i] = new Fiction(fictionTitle);
        }

        for (int i = 5; i < 10; i++) {
            System.out.print("Enter the title of a non-fiction book: ");
            String nonFictionTitle = console.nextLine();
            books[i] = new NonFiction(nonFictionTitle);
        }

        System.out.println("Details of all books:");
        for (Book book : books) {
            System.out.println("Title: " + book.getTitle());
            System.out.println("Price: $" + book.getPrice());
            System.out.println();
        }

        console.close();
    }
}