一般的なプログラミング言語の概念
====

## Hello, World
- プロジェクト/HelloWorld

```kt
fun main(args: Array<String>) {
    println("Hello Kotlin")
}
```

- `fun`キーワードで関数定義する。`fun 関数名(引数リスト)`となる。型は後置形式でかくことになるもよう
- コードブロックは`{}`で定義
- `println`はJavaの`System.out.println`を呼び出している。
   - 標準ライブラリは明示的にimportを指定しなくてもimportされる模様

## コメントと変数定義
- プロジェクト/Varibles
- 変数定義は`var`キーワードと`val`キーワードで定義する
    - `var`は変数（mutable）、`val`は定数となる(immutable)
- コメントは、`/**/`でブロックコメント、`//`でインラインコメントになる
  - 当たり前だが`javadoc`形式のアノテーションができる。

## 標準入出力
- プロジェクト/StdIO
- Javaと同じく、標準入出力には、`System.in`と`System.out`を使う
   - しかし、 inはキーワードに登録されているので利用するときはSystem.\`in\`としてエスケープする
- KotlinはJavaと相互運用できるので、`Scanner`や`readLine`、`BufferedReader`を使って読み込める
   - `bufferedReader`は`InputStream`に生えているのでStreamを生成した後bufferedからアクセスできる

## データ型
- プロジェクト/DataTypes
- 数値型
  - Kotlinは以下のビルトイン型を提供している
  - リテラル表記は、他の言語と同様に`L`や`F`のサフィックスをつける

|型|ビット幅|
|:----|:----|
|Double|64|
|Float|32|
|Long|64|
|Int|32|
|Short|16|
|Byte	|8|

- 文字は`Char`
- 文字列は`String`
- 配列
  - Kotlinはプリミティブ型（`ByteArray`、`ShortArray`、`IntArray`等）の配列について、オーバーヘッド無しでボクシングができる特別なクラスがある

## 演算子
- プロジェクト/Operators
- 大体他のC系の言語と同じ
- 算術演算子
    - `+`, `-`, `/`, `*`,`%`, `+=`, `-=`, `/=`, `*=`, `%=` 
- 比較演算子
    - `>`, `>=`, `==`, `<=`, `<`
- 論理演算子
    - `&&` `||` `!` 
- ビット演算子
    - infix形式で or and xorを書けるが、利用機会はそれほどないので省略する

## 制御構文
- プロジェクト/ControlFlow
- 条件分岐には、`if`式を使う
   - `if`は文ではなく式なので値を返すことができる。
     - なので、kotlinには3項演算子が存在しない
   - `if`式の値は、ブロックの最後の式の値となる
 - 多分岐は、`when`式
   - `when`も`it`と同様に、式なので値を返せる。
- 繰り返しは`for`, `while`, `do-while`, `HOF(repeatなど)`を使う
  - stat..end　の形で rangeが作れる
  - `break`, `continue`も可能
