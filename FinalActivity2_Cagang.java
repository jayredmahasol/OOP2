import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class FinalActivity2_Cagang extends JFrame {
    private int totalPoints = 0;
    private int questionIndex = 0;

    private JLabel questionLabel;
    private JCheckBox[] checkboxes;
    private JButton submitButton;

    private String[] questions = {
            "What is the capital of France?",
            "Which planet is known as the Red Planet?",
            "What is the largest mammal?",
            "In what year did World War II end?",
            "What is the powerhouse of the cell?"
    };

    private String[][] answers = {
            {"Paris", "Berlin", "Rome"},
            {"Mars", "Venus", "Jupiter"},
            {"Blue Whale", "Elephant", "Giraffe"},
            {"1945", "1939", "1941"},
            {"Mitochondria", "Nucleus", "Ribosome"}
    };

    private String[] correctAnswers = {"Paris", "Mars", "Blue Whale", "1945", "Mitochondria"};

    public FinalActivity2_Cagang() {
        setTitle("Quiz Game");
        setSize(400, 200);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new GridLayout(5, 1));

        questionLabel = new JLabel(questions[questionIndex], SwingConstants.CENTER);
        add(questionLabel);

        checkboxes = new JCheckBox[3];
        for (int i = 0; i < 3; i++) {
            checkboxes[i] = new JCheckBox(answers[questionIndex][i]);
            add(checkboxes[i]);
        }

        submitButton = new JButton("Submit");
        submitButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                checkAnswer();
                if (questionIndex < 4) {
                    questionIndex++;
                    updateQuestion();
                } else {
                    displayResult();
                }
            }
        });
        add(submitButton);

        setLocationRelativeTo(null);
        setVisible(true);
    }

    private void updateQuestion() {
        questionLabel.setText(questions[questionIndex]);
        for (int i = 0; i < 3; i++) {
            checkboxes[i].setText(answers[questionIndex][i]);
            checkboxes[i].setSelected(false);
        }
    }

    private void checkAnswer() {
        int selectedCount = 0;
        int correctCount = 0;
    
        for (int i = 0; i < 3; i++) {
            if (checkboxes[i].isSelected()) {
                selectedCount++;
                if (checkboxes[i].getText().equals(correctAnswers[questionIndex])) {
                    correctCount++;
                }
            }
        }
    
        if (correctCount == 1 && selectedCount == 1) {
            totalPoints += 5;
        } else if (correctCount == 1 && selectedCount == 2) {
            totalPoints += 2;
        } else if (correctCount == 1 && selectedCount == 3) {
            totalPoints += 1;
        }
    }

    private void displayResult() {
        String message;
        if (totalPoints > 21) {
            message = "Fantastic!";
        } else if (totalPoints > 15) {
            message = "Very good";
        } else {
            message = "OK";
        }
        JOptionPane.showMessageDialog(this, "Your total points: " + totalPoints + "\n" + message);
        System.exit(0);
    }

    public static void main(String[] args) {
        new FinalActivity2_Cagang();
    }
}