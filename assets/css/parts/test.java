import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.ArrayList;
import java.util.List;
import java.io.*;

@SuppressWarnings("serial")
public class Main extends JPanel implements ActionListener {

    private static Square mySquare;
    private static Circle myCircle;
    public boolean SquareCheck;
    public boolean CircleCheck;
    public boolean UndoCheck;
    public boolean RedoCheck;
    private static Color myColor;
    private JToggleButton buttonSquare;
    private JToggleButton buttonCircle;
    JFrame frame;
    JTextField saveName;
    private String fileName;
    private JButton red;
    private JButton blue;
    private JButton yellow;
    private JButton green;
    private JButton black;
    private JButton white;
    private JButton undo;
    private JButton redo;
    private JButton save;
    private JButton load;
    private int listPosition;
    int x, y, x2, y2;
    private static List<Object> myShape;


    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
//        for (Object shape: myShape) {
//              if (shape instanceof  Square){
//                  g.drawRect(((Square) shape).x,((Square) shape).y,((Square) shape).width,((Square) shape).length);
//              }else if (shape instanceof  Circle){
//                  g.drawOval(((Circle) shape).x,((Circle) shape).y,((Circle) shape).width,((Circle) shape).length);
//              }
//        }
//        while(listPosition<=myShape.size()){
//
//        }

        if (myShape.size()>0){
            for (int i=1;i<=listPosition;i++){
                if (myShape.get(i-1) instanceof  Square){
                    g.drawRect(((Square) myShape.get(i-1)).x,((Square) myShape.get(i-1)).y,((Square) myShape.get(i-1)).width,((Square) myShape.get(i-1)).length);
                    //g.setColor((Color) figure_color);
                    //drawPerfectRect(g,((Square) myShape.get(i-1)).x,((Square) myShape.get(i-1)).y,((Square) myShape.get(i-1)).width +((Square) myShape.get(i-1)).x ,((Square) myShape.get(i-1)).length + ((Square) myShape.get(i-1)).y);

                }else if (myShape.get(i-1) instanceof  Circle){
                    g.drawOval(((Circle) myShape.get(i-1)).x,((Circle) myShape.get(i-1)).y,((Circle) myShape.get(i-1)).width,((Circle) myShape.get(i-1)).length);
                }
            }
        }


        if (SquareCheck) {
            buttonSquare.setSelected(true);
            buttonCircle.setSelected(false);
            for (int i=myShape.size()-1;i>listPosition;i--)
            {
                myShape.remove(i);
            }
            g.setColor(myColor);
            drawPerfectRect(g, x, y, x2, y2);
            System.out.println(myShape.size() + " and " + listPosition);
            //System.out.println(listPosition + " and " + myShape.size());

            listPosition = myShape.size();

        }
        if (CircleCheck) {
            buttonCircle.setSelected(true);
            buttonSquare.setSelected(false);
            for (int i=myShape.size()-1;i>listPosition;i--)
            {
                myShape.remove(i);
            }
            g.setColor(myColor);
            drawPerfectOval(g, x, y, x2, y2);

            listPosition = myShape.size();
        }
        if (UndoCheck) {
            UndoCheck = false;
            if ((listPosition - 1) >= 0) {
                listPosition--;
            }
        }
        if (RedoCheck) {
            RedoCheck = false;
            if (!(listPosition == myShape.size())) {
                listPosition++;
            }

        }


        if (myShape.size()>0){
            for (int i=1;i<=listPosition;i++){
                if (myShape.get(i-1) instanceof  Square){
                    g.drawRect(((Square) myShape.get(i-1)).x,((Square) myShape.get(i-1)).y,((Square) myShape.get(i-1)).width,((Square) myShape.get(i-1)).length);
                    //g.setColor((Color) figure_color);
                    //drawPerfectRect(g,((Square) myShape.get(i-1)).x,((Square) myShape.get(i-1)).y,((Square) myShape.get(i-1)).width +((Square) myShape.get(i-1)).x ,((Square) myShape.get(i-1)).length + ((Square) myShape.get(i-1)).y);

                }else if (myShape.get(i-1) instanceof  Circle){
                    g.drawOval(((Circle) myShape.get(i-1)).x,((Circle) myShape.get(i-1)).y,((Circle) myShape.get(i-1)).width,((Circle) myShape.get(i-1)).length);
                }
            }
        }
    }

    public Main() {
        frame = new JFrame();
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        x = y = x2 = y2 = 0;
        MyMouseListener listener = new MyMouseListener();
        addMouseListener(listener);
        addMouseMotionListener(listener);

        buttonSquare = new JToggleButton("■");
        buttonCircle = new JToggleButton("●");

        buttonCircle.addActionListener(this);
        buttonSquare.addActionListener(this);

        this.add(buttonCircle);
        this.add(buttonSquare);

        red = new JButton("   ");
        red.setBackground(Color.red);
        red.addActionListener(this);
        this.add(red);

        blue = new JButton("   ");
        blue.setBackground(Color.blue);
        blue.addActionListener(this);
        this.add(blue);

        yellow = new JButton("   ");
        yellow.setBackground(Color.yellow);
        yellow.addActionListener(this);
        this.add(yellow);

        green = new JButton("   ");
        green.setBackground(Color.green);
        green.addActionListener(this);
        this.add(green);

        black = new JButton("   ");
        black.setBackground(Color.black);
        black.addActionListener(this);
        this.add(black);

        white = new JButton("   ");
        white.setBackground(Color.white);
        white.addActionListener(this);
        this.add(white);

        undo = new JButton("UNDO");
        undo.addActionListener(this);
        this.add(undo);

        redo = new JButton("REDO");
        redo.addActionListener(this);
        this.add(redo);

        save = new JButton("save");
        save.addActionListener(this);
        this.add(save);

        load = new JButton("load");
        load.addActionListener(this);
        this.add(load);

        saveName = new JTextField("Enter File Name");
        saveName.addActionListener(this);
        this.add(saveName);


//        JPanel p = new JPanel();
//        p.add(red);
//        p.add(blue);
//        p.add(yellow);
//        p.add(green);
//        p.add(white);
//        p.add(black);
//
//        p.setSize(100,300);
//        frame.add(p);

        frame.add(this);

        frame.setSize(800, 500);
        frame.setVisible(true);

    }

    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == buttonSquare) {
            CircleCheck = false;
            SquareCheck = true;
        } else if (e.getSource() == buttonCircle) {
            SquareCheck = false;
            CircleCheck = true;
        }
        if (e.getSource() == red) {
            myColor = Color.red;
            figure_color.add(myColor);
        }
        if (e.getSource() == blue) {
            myColor = Color.blue;
            figure_color.add(myColor);

        }
        if (e.getSource() == black) {
            myColor = Color.black;
            figure_color.add(myColor);

        }
        if (e.getSource() == green) {
            myColor = Color.green;
            figure_color.add(myColor);

        }
        if (e.getSource() == yellow) {
            myColor = Color.yellow;
            figure_color.add(myColor);

        }
        if (e.getSource() == white) {
            myColor = Color.white;
            figure_color.add(myColor);

        }
        if (e.getSource() == undo) {
            SquareCheck = false;
            CircleCheck = false;
            UndoCheck = true;
            repaint();
        }
        if (e.getSource() == redo) {
            SquareCheck = false;
            CircleCheck = false;
            RedoCheck = true;
            repaint();
        }
        if (e.getSource() == save) {
//            while(myShape.size()!=listPosition){
//                myShape.size();
//            }
            fileName=saveName.getText();
            fileName+=".ser";
            try {
                saveToFile(fileName, myShape);
            } catch (IOException ex) {
                ex.printStackTrace();
            }
        }
        if (e.getSource()==load){
            fileName=saveName.getText();
            fileName+=".ser";
            try {
                myShape= (List<Object>) restoreFromFile(fileName);
            } catch (IOException ex) {
                ex.printStackTrace();
            } catch (ClassNotFoundException ex) {
                ex.printStackTrace();
            }
            listPosition=myShape.size();
            repaint();
        }

    }

    public void setStartPoint(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public void setEndPoint(int x, int y) {
        x2 = (x);
        y2 = (y);
    }

    public void drawPerfectRect(Graphics g, int x, int y, int x2, int y2) {
        int px = Math.min(x, x2);
        int py = Math.min(y, y2);
        int pw = Math.abs(x - x2);
        int ph = Math.abs(y - y2);
        g.drawRect(px, py, pw, ph);
        // g.fillRect(px, py, pw, ph);
    }

    public void drawPerfectOval(Graphics g, int x, int y, int x2, int y2) {
        int px = Math.min(x, x2);
        int py = Math.min(y, y2);
        int pw = Math.abs(x - x2);
        int ph = Math.abs(y - y2);
        g.drawOval(px, py, pw, ph);
    }


    class MyMouseListener extends MouseAdapter {
        public void mousePressed(MouseEvent e) {

            setStartPoint(e.getX(), e.getY());
        }

        public void mouseDragged(MouseEvent e) {
            setEndPoint(e.getX(), e.getY());
            repaint();
        }

        public void mouseReleased(MouseEvent e) {

            setEndPoint(e.getX(), e.getY());
            repaint();
            if (SquareCheck) {

                myShape.add(new Square(Math.min(x,e.getX()), Math.min(y,e.getY()), Math.abs(e.getX() - x), Math.abs(e.getY() - y)));
                System.out.println(x + " Y:" + y + " W: " + (e.getX() - x) + " L " + (e.getY() - y) + "d");

            } else if (CircleCheck) {
                myShape.add(new Circle(Math.min(x,e.getX()), Math.min(y,e.getY()), Math.abs(e.getX() - x), Math.abs(e.getY() - y)));
            }

        }
    }

    static void saveToFile(String outputFile, Object object) throws IOException {
        FileOutputStream fileOut = new FileOutputStream(outputFile);
        ObjectOutputStream objectOut = new ObjectOutputStream(fileOut);
        objectOut.writeObject(object);
        objectOut.close();
        System.out.println("The Object  was successfully written to a file");
    }

    static Object restoreFromFile(String filepath) throws IOException, ClassNotFoundException {
        FileInputStream fileIn = new FileInputStream(filepath);
        ObjectInputStream objectIn = new ObjectInputStream(fileIn);
        Object obj = objectIn.readObject();
        System.out.println("The Object has been read from the file");
        objectIn.close();
        return obj;
    }


    public static void main(String[] args) {
        mySquare = new Square(30, 50, 50, 50);
        myCircle = new Circle(60, 100, 50, 50);
        myShape = new ArrayList<Object>();
        new Main();
    }
}