import java.util.Scanner;
import java.io.InputStreamReader;

/**
 * 標準入力から読みとり
 * 
 */
fun main(args: Array<String>) {
    //行読み取り
    val line = readLine() as String;
    println("readLine=$line")

    //Scannerを使った読み取り
    val scan = Scanner(System.`in`)
    val str = scan.nextLine();
    println("scaner.nextLine=$str");  

    //InputStremからBufferedReaderで読み取り
    val buffer = InputStreamReader(System.`in`).buffered().use {
        it.readText();
    }
    println("buffer=$buffer")
}