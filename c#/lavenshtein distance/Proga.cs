using System;

public class program {
    public static void Main(string[] args) {
        Console.WriteLine(lavenshteinDistance("кабак", "куба"));
    }
    public static int lavenshteinDistance(string a, string b) {
        string longer = a.Length > b.Length ? a : b;
        return longer.Length - getCommonPart(a, b).Length;
    }
    public static string getCommonPart(string a, string b) {
        string commonPart = "";
        string longer = a.Length > b.Length ? a : b;
        string shorter = a.Length > b.Length ? b : a;
        for(int i = 0; i <= shorter.Length; i++) {
            for(int j = 0; j <= shorter.Length; j++) {
                if(i +j <= shorter.Length) {
                    if(i <= j) {
                        if(longer.Contains(shorter.Substring(i, j))) {
                            commonPart = shorter.Substring(i, j).Length > 
                            commonPart.Length ? 
                            shorter.Substring(i, j) : 
                            commonPart;
                        }
                        if(i == shorter.Length - 1 && longer.Contains(shorter.Substring(i))) {
                            commonPart = shorter.Substring(i).Length > 
                            commonPart.Length ? 
                            shorter.Substring(i) : 
                            commonPart;
                        }
                    }
                }
            }
        }
            if(a.Length > 0 && 
            b.Length > 0 && 
            commonPart.Length > 0 && 
            a.Split(commonPart).Length > 0 && 
            b.Split(commonPart).Length > 0) {
                if(a.Split(commonPart)[0].Length > 0 && b.Split(commonPart)[0].Length > 0) {
                    return getCommonPart(a.Split(commonPart)[0], b.Split(commonPart)[0]) + commonPart;
                }
                if(a.Split(commonPart)[1].Length > 0 && b.Split(commonPart)[1].Length > 0) {
                    return commonPart + getCommonPart(a.Split(commonPart)[1], b.Split(commonPart)[1]);
                }
            }
        return commonPart;
    }
}