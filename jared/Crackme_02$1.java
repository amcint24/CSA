/*    */ import java.awt.event.ActionEvent;
/*    */ import java.awt.event.ActionListener;
/*    */ import javax.swing.JFormattedTextField;
/*    */ import javax.swing.JOptionPane;
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */ class null
/*    */   implements ActionListener
/*    */ {
/*    */   public void actionPerformed(ActionEvent paramActionEvent) {
/* 28 */     char c1 = '䉂';
/* 29 */     char c2 = '샓';
/* 30 */     char c3 = 'ጷ';
/* 31 */     char c4 = '?';
/*    */ 
/*    */ 
/*    */ 
/*    */ 
/*    */     
/* 37 */     String str = "flag_{" + Integer.toHexString(c1).toUpperCase() + "-" + Integer.toHexString(c3).toUpperCase() + "-" + Integer.toHexString(c4).toUpperCase() + "-" + Integer.toHexString(c2).toUpperCase() + "}";
/*    */     
/* 39 */     if (serialField.getValue().equals(str)) {
/* 40 */       JOptionPane.showMessageDialog(null, "Crongratulations!");
/* 41 */       System.exit(0);
/*    */     } else {
/* 43 */       JOptionPane.showMessageDialog(null, "Incorrect!", "Error", 0);
/* 44 */       System.exit(1);
/*    */     } 
/*    */   }
/*    */ }


/* Location:              C:\Dev\CSA\jared\Crackme_02.jar!\Crackme_02$1.class
 * Java compiler version: 11 (55.0)
 * JD-Core Version:       1.1.3
 */