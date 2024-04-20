// Program.cs
// このファイルはGitリポジトリでの管理を前提に設計されており、初心者がGitの基本操作を学ぶために使用します

using System;

/// <summary>
/// 基本的なプログラム機能を提供するクラス
/// </summary>
public class BasicProgram
{
    /// <summary>
    /// プログラムのメインエントリーポイント
    /// </summary>
    public static void Main()
    {
        GreetUser();
        GetUserInput();
        PerformCalculation();
    }

    /// <summary>
    /// ユーザーに挨拶をする
    /// </summary>
    public static void GreetUser()
    {
        Console.WriteLine("Hello, World! Gitで管理されているプログラムへようこそ。");
    }

    /// <summary>
    /// ユーザーから文字列を入力してもらい、それを表示する
    /// </summary>
    public static void GetUserInput()
    {
        Console.WriteLine("あなたの名前を入力してください：");
        string userName = Console.ReadLine();
        Console.WriteLine($"こんにちは、{userName}!");
    }

    /// <summary>
    /// 簡単な数値計算を行い、結果を表示する
    /// </summary>
    public static void PerformCalculation()
    {
        Console.WriteLine("2つの数値（5 と 3）を足します。");
        int result = AddNumbers(5, 3);
        Console.WriteLine($"計算結果は：{result}");
    }

    /// <summary>
    /// 2つの整数を足す
    /// </summary>
    /// <param name="a">最初の整数</param>
    /// <param name="b">二番目の整数</param>
    /// <returns>整数の合計</returns>
    private static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}
