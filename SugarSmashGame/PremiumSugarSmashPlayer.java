import java.util.Scanner;

public class PremiumSugarSmashPlayer extends SugarSmashPlayer {

    private int premium;
    private boolean access;
    private int[] premiumScores; // premium player scores
    private int totalLevels; // total levels including premium levels
    Scanner console = new Scanner(System.in);

    public PremiumSugarSmashPlayer() {
        super();
        premium = 0;
        access = false;
        premiumScores = new int[50]; // 10 regular levels and 40 extra premium levels
        totalLevels = 10; // initialize with regular levels
    }

    public PremiumSugarSmashPlayer(int playerId, String screenName, int highScores, int premium, boolean access) {
        super(playerId, screenName, highScores);
        this.premium = premium;
        this.access = access;
        premiumScores = new int[50];
        totalLevels = 10;
    }

    public void setPremium(int premium) {
        this.premium = premium;
    }

    public int getPremium() {
        return this.premium;
    }

    public void setAccess(boolean access) {
        this.access = access;
        if (access) {
            totalLevels += 40; //+40 levels when premium access is granted
        }
    }

    public boolean getAccess() {
        return this.access;
    }

    public void display() {
        super.display();

        System.out.print("Do you want to avail Premium for only 2.99$? (yes/no): ");
        String choice = console.next();

        if (choice.equalsIgnoreCase("yes")) {
            System.out.print("Enter the cost: ");
            double cost = console.nextDouble();

            if (cost == 2.99) {
                setAccess(true); //grant premium access
                System.out.println("\n<< Premium access granted! You can now set scores for premium levels. >>");

                //set scores if the user has earned at least 100 points at all previous levels
                if (checkPreviousLevels()) {
                    for (int a = 11; a <= totalLevels; a++) {
                        System.out.print("Enter the score for level " + a + ": ");
                        int score = console.nextInt();
                        premiumScores[a - 11] = score;
                    }

                    System.out.println("\n<< Premium Level " + getScreenName() + "'s Scores >>");
                    for (int a = 11; a <= totalLevels; a++) {
                        System.out.println("Level " + a + ": " + premiumScores[a - 11]);
                    }
                } else {
                    System.out.println("You need to earn at least 100 points at all previous levels to set scores for premium levels.");
                }
            } else {
                System.out.println("The cost you entered is not valid. Premium access not granted.");
            }
        } else {
            System.out.println("Premium access not granted.");
        }
    }

    //to check if the user has earned at least 100 points at all previous levels
    private boolean checkPreviousLevels() {
        for (int a = 1; a <= 10; a++) {
            if (getScore(a) < 100) {
                return false;
            }
        }
        return true;
    }
}