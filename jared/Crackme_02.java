/*    */ import java.awt.Color;
/*    */ import java.awt.Font;
/*    */ import java.awt.event.ActionListener;
/*    */ import javax.swing.Box;
/*    */ import javax.swing.JFormattedTextField;
/*    */ import javax.swing.JFrame;
/*    */ import javax.swing.JOptionPane;
/*    */ 
/*    */ public class Crackme_02 {
/*    */   public static void main(String[] paramArrayOfString) throws Exception {
/* 11 */     Box box = Box.createVerticalBox();
/* 12 */     Font font = new Font("Courier", 1, 36);
/* 13 */     Color color1 = new Color(250, 250, 250, 255);
/* 14 */     Color color2 = new Color(255, 95, 0, 255);
/* 15 */     Color color3 = new Color(22, 22, 22, 255);
/* 16 */     Color color4 = new Color(255, 95, 0, 100);
/*    */     
/* 18 */     final JFormattedTextField serialField = new JFormattedTextField(new MaskFormatter("flag_{HHHH-HHHH-HHHH-HHHH}"));
/* 19 */     jFormattedTextField.setFont(font);
/* 20 */     jFormattedTextField.setSelectionColor(color1);
/* 21 */     jFormattedTextField.setForeground(color2);
/* 22 */     jFormattedTextField.setBackground(color3);
/* 23 */     jFormattedTextField.setCaretColor(color4);
/* 24 */     jFormattedTextField.setValue("flag_{0000-0000-0000-0000}");
/*    */     
/* 26 */     jFormattedTextField.addActionListener(new ActionListener() {
/*    */           public void actionPerformed(ActionEvent param1ActionEvent) {
/* 28 */             char c1 = '䉂';
/* 29 */             char c2 = '샓';
/* 30 */             char c3 = 'ጷ';
/* 31 */             char c4 = '?';
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */             
/* 37 */             String str = "flag_{" + Integer.toHexString(c1).toUpperCase() + "-" + Integer.toHexString(c3).toUpperCase() + "-" + Integer.toHexString(c4).toUpperCase() + "-" + Integer.toHexString(c2).toUpperCase() + "}";
/*    */             
/* 39 */             if (serialField.getValue().equals(str)) {
/* 40 */               JOptionPane.showMessageDialog(null, "Crongratulations!");
/* 41 */               System.exit(0);
/*    */             } else {
/* 43 */               JOptionPane.showMessageDialog(null, "Incorrect!", "Error", 0);
/* 44 */               System.exit(1);
/*    */             } 
/*    */           }
/*    */         });
/*    */     
/* 49 */     box.add(jFormattedTextField);
/*    */     
/* 51 */     JFrame jFrame = new JFrame("Crackme 02");
/* 52 */     jFrame.setUndecorated(true);
/* 53 */     jFrame.setBackground(new Color(1.0F, 1.0F, 1.0F, 0.5F));
/* 54 */     jFrame.getContentPane().add(box);
/* 55 */     jFrame.pack();
/* 56 */     jFrame.setLocationRelativeTo(null);
/* 57 */     jFrame.setDefaultCloseOperation(3);
/* 58 */     jFrame.setVisible(true);
/*    */   }
/*    */ }


/* Location:              C:\Dev\CSA\jared\Crackme_02.jar!\Crackme_02.class
 * Java compiler version: 11 (55.0)
 * JD-Core Version:       1.1.3
 */