
import java.util.ArrayList;
import java.util.Comparator;
//import java.util.Random;

public class tast1_1 {
    public static void main(String[] args) {
         
                    
       ArrayList<String> list = new ArrayList<>();
       list.add ( "Земля");
       list.add ( "Марс");
       list.add ( "Юпитер");
       list.add ("Юпитер");
       list.add ( "Венера");
       list.add ( "Плутон");
       list.add ( "Сатурн");
       list.add ( "Земля");
       list.add ( "Земля");
       System.out.println(list);
       list.sort(Comparator.naturalOrder());

       System.out.println(list);
    }
}   

//
