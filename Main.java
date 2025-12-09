import java.util.Scanner;

public class Main {
    public static int euclideanAlgorithm(int a, int b) {
        if (a <= 0 || b <= 0) {
            throw new IllegalArgumentException("Liczby muszą być dodatnie.");
        }
        while (a != b) {
            if (a > b) {
                a = a - b;
            }else {
                b = b - a;
            }
        }
        return a;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Program oblicza NWD dwóch liczb całkowitych dodatnich.");
        try {
            System.out.print("Podaj pierwszą liczbę (a): ");
            int a = scanner.nextInt();

            System.out.print("Podaj drugą liczbę (b): ");
            int b = scanner.nextInt();

            int nwd = euclideanAlgorithm(a, b);
            System.out.println("Największy wspólny dzielnik (NWD) liczb " + a + " i " + b + " wynosi: " + nwd);
        }
        catch (IllegalArgumentException e) {
            System.out.println("Błąd: " + e.getMessage());
        }
        catch (Exception e) {
            System.out.println("Błąd: Wprowadzono nieprawidłowe dane. Proszę wprowadzić liczby całkowite.");
        }
        finally {
            scanner.close();
        }
    }
}