fun main(args: Array<String>) {
    //Integer
    val n = 100
    val l = 100L
    println("$n is int")    
    println("$l is long")

    //Floating Point
    val d = 100.5
    val f = 100.5F
    println("$d is Double")    
    println("$f is Float")

    //Boolean
    val bool = true
    println("$bool is Boolean")    
   
    //String
    val str = "String"
    println("$str is String")  
    
    //Array
    val a = intArrayOf(1,2,3,4,5)
    for (v in a) {
        println("$v")
    }
}