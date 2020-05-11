/**
 * Main関数
 * @param args: Array<String>
 * @return void
 */
fun main(args: Array<String>) {
    var variable = "varは再代入できる";
    val value = "valは再代入できない";
    println(variable)
    println(value) 

    variable ="再代入後"
    //value ="再代入できない"
    println(variable)
    println(value) 
}
