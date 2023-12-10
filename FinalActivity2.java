import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class FinalActivity2 extends JFrame implements ActionListener{
    JLabel quest;
    JButton confirm;
    JCheckBox choice1, choice2, choice3;

    int point1 = 0, point2 = 0, point3 = 0, point4 = 0, point5 = 0;
    public FinalActivity2() {

        String question1 = "What is the color of snow?";
        String question2 = "Select the color of the leaves.";
        String question3 = "What is the color of chili";
        String question4 = "What is the color of blood?";
        String question5 = "What is the color of cotton?";

        quest = new JLabel(question1, SwingConstants.CENTER);
        quest.setFont(new Font("Times New Roman",Font.BOLD,25));

        choice1 = new JCheckBox("Red");
        choice2 = new JCheckBox("White");
        choice3 = new JCheckBox("Green");

        confirm = new JButton("CONFIRM");

        confirm.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {

                int score = 0;

                switch(quest.getText()) {

                    case "What is the color of snow?":
                        if(choice2.isSelected()) point1 = 5;
                        if(choice1.isSelected()) point1 = point1 > 0 ? point1 - 2: point1;
                        if(choice3.isSelected()) point1 = point1 > 0 ? point1 - 2: point1;
                        score += point1;
                        quest.setText(question2);
                        choice1.setSelected(false);
                        choice2.setSelected(false);
                        choice3.setSelected(false);
                        break;

                    case "Select the color of the leaves.":
                        if(choice3.isSelected()) point2 = 5;
                        if(choice1.isSelected()) point2 = point2 > 0 ? point2 - 2: point2;
                        if(choice2.isSelected()) point2 = point2 > 0 ? point2 - 2: point2;
                        score += point2;
                        quest.setText(question3);
                        choice1.setSelected(false);
                        choice2.setSelected(false);
                        choice3.setSelected(false);
                        break;

                    case "What is the color of chili":
                        if(choice1.isSelected()) point3 = 5;
                        if(choice2.isSelected()) point3 = point3 > 0 ? point3 - 2: point3;
                        if(choice3.isSelected()) point3 = point3 > 0 ? point3 - 2: point3;
                        score += point3;
                        quest.setText(question4);
                        choice1.setSelected(false);
                        choice2.setSelected(false);
                        choice3.setSelected(false);
                        break;

                    case "What is the color of blood?":
                        if(choice1.isSelected()) point4 = 5;
                        if(choice2.isSelected()) point4 = point4 > 0 ? point4 - 2: point4;
                        if(choice3.isSelected()) point4 = point4 > 0 ? point4 - 2: point4;
                        score += point4;
                        quest.setText(question5);
                        choice1.setSelected(false);
                        choice2.setSelected(false);
                        choice3.setSelected(false);
                        break;

                    case "What is the color of cotton?":
                        if(choice2.isSelected()) point5 = 5;
                        if(choice1.isSelected()) point5 = point5 > 0 ? point5 - 2: point5;
                        if(choice3.isSelected()) point5 = point5 > 0 ? point5 - 2: point5;
                        score += point5;
                        choice1.setSelected(false);
                        choice2.setSelected(false);
                        choice3.setSelected(false);
                        break;
                }

                int totalScore = point1 + point2 + point3 + point4 + point5;

                if(totalScore >= 21)
                    JOptionPane.showMessageDialog(null,String.format("Fantastic!!!, Your score is " + totalScore));
                else if(totalScore >= 15)
                    JOptionPane.showMessageDialog(null,String.format("Very Good!! Your score is " + totalScore));
                else
                    JOptionPane.showMessageDialog(null,String.format("OK! Your score is " + totalScore));
            }
        });

        setTitle("Quiz Game");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setLayout(new GridLayout(5,1));
        setSize(500, 500);

        add(quest);
        add(choice1);
        add(choice2);
        add(choice3);
        add(confirm);

        setVisible(true);
    }

    public static void main(String [] args) {
        new FinalActivity2();
    }

    public void actionPerformed(ActionEvent e) {

    }
}

