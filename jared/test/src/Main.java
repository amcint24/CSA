public class Main {

    public static void main(String[] args) {
        /* 28 */     char c1 = '䉂';
        /* 29 */     char c2 = '샓';
        /* 30 */     char c3 = 'ጷ';
        /* 31 */     char c4 = '?';


        /*
        Integer.toHexString(16962).toUpperCase(),
         Integer.toHexString(4919).toUpperCase(),
         Integer.toHexString(57005).toUpperCase(),
         Integer.toHexString(49363).toUpperCase())  */
        /*    */
        /*    */
        /*    */
        /*    */
        /* 37 */     String str = "flag_{" + Integer.toHexString(c1).toUpperCase() + "-" + Integer.toHexString(c3).toUpperCase() + "-" + Integer.toHexString(c4).toUpperCase() + "-" + Integer.toHexString(c2).toUpperCase() + "}";
        /*    */
        System.out.println(Integer.toHexString(16962));
        System.out.println(Integer.toHexString(4919));
        System.out.println(Integer.toHexString(57005));
        System.out.println(Integer.toHexString(49363));
        System.out.println(str);
    }
}
