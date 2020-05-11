fun main(args : Array<String>) {
    /**
     * Arithmetic operators
     */
    println("---arithmetic operators----")
    val a = 2
    val b = 3
    println("$a + $b = ${a + b}")
    println("$a - $b = ${a - b}")
    println("$a / $b = ${a / b}")
    println("$a * $b = ${a * b}")
    println("$a % $b = ${a % b}")
    

    println("---argumented assignment operators----")
    var c=a; c+=b
    println("$a + $b = $c")
    c=a; c-=b
    println("$a - $b = $c")
    c=a; c/=b
    println("$a / $b = $c")
    c=a; c*=b
    println("$a * $b = $c")
    c=a; c%=b
    println("$a % $b = $c")
    
    /**
     * Comparison operators
     */
    println("---comparison operators----")
    println("$a >  $b = ${a > b}")
    println("$a >= $b = ${a >= b}")
    println("$a == $b = ${a == b}")
    println("$a <= $b = ${a <= b}")
    println("$a <  $b = ${a < b}")

    /**
     * Logical Operators 
     */
    println("---logical operators----")
    val andResult = true && false
    println("true and false = $andResult")

    val orResult = true || false
    println("true or false = $orResult")

    val notResult = !true 
    println("not true = $notResult")

   
}