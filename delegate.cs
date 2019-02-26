/*
delegateとは

メソッドを割り当てることができる変数
 */


using System;
 
// 型を宣言
delegate void MyDelegate();
 
class Animal{
 
    // 登録するメソッドを作成
    static void Mammalian() => Console.WriteLine("Lion");
    static void Reptiles() => Console.WriteLine("Snake");
 
    static void Main(){
 
        // 変数を宣言
        MyDelegate ShowName;
 
        // メソッドを登録
        ShowName = Mammalian;
        ShowName += Reptiles;
 
        ShowName();
 
    }
}
 