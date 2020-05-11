/**
 * 論理演算子と制御構文
 */
fun main(args: Array<String>) {
    println("Please input integer");

    val line = readLine();
    val n = Integer.parseInt(line)   
 
    /**if expression */
    println("----if----")
    val result = if( n % 2 == 0) {
        "even"
    }
    else {
        "odd"
    }
    println("$n is an $result number")

    /**when expression */
    println("----when----")
    val whenResult = when {
        n % 3 == 1 -> {
            "1 "

        }
        (n % 3 == 2) -> {
            "2"
        }
        else -> {
            "3の倍数です"
        }
    }
    println("$n mod 3 = $whenResult")
    
    /** for */
    println("----for----")
    for(i in 1 .. 5) {
        println(i);
    }
    
    /** while */
    println("----while----")
    val list = intArrayOf(1,2,3,4,5)
    var i =0;
    while(i < list.size) {
        println(list[i])
        i++
    }

    /** do-while */
    println("----do-while----")

    i=0
    do {
        println(list[i])
        i++
    }
    while(i<list.size)
 
    /** higher order function(repeat) */
    println("----higher order function (repeat)----")
    repeat(10) {
        println("repeat")
    }
}