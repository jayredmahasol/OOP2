import java.util.Scanner;

public class UseBook {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        System.out.print("Enter the title of a fiction book: ");
        String fictionTitle = console.nextLine();
        Fiction fictionBook = new Fiction(fictionTitle);

        System.out.print("Enter the title of a non-fiction book: ");
        String nonFictionTitle = console.nextLine();
        NonFiction nonFictionBook = new NonFiction(nonFictionTitle);

        System.out.println("Fiction Book:");
        System.out.println("Title: " + fictionBook.getTitle());
        System.out.println("Price: $" + fictionBook.getPrice());

        System.out.println("\nNon-Fiction Book:");
        System.out.println("Title: " + nonFictionBook.getTitle());
        System.out.println("Price: $" + nonFictionBook.getPrice());

        console.close();
    }
}