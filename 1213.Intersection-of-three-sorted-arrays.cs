using System.Collections.Generic;
using System.Threading.Tasks;
using Internal;
using System;
using System.IO;

public class Solution {
    public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3) {
        List<int> res = new();
        foreach(int i in arr1){
            if (Find(i, arr2, 0, arr2.Length - 1)){
                if (Find(i, arr3, 0, arr3.Length - 1)) res.Add(i);
            }
        }
        return res;
        
    }

    public bool Find(int key, int[] arr, int l, int r){
        if (l > r) return false;
        else{
            int m = (l + r)/2;
            if (key == arr[m]) return true;
            else if (key < arr[m]) return Find(key, arr, l, m - 1);
            else if (key > arr[m]) return Find(key, arr, m + 1, r);
        }
        return false;
    }
    // static void Main(string[] args) {
    //     Solution s = new();
    //     int[] a = {1,2,3,4,5};
    //     int[] b = {1,2,5,7,9};
    //     int[] c = {1,3,4,5,8};
    //     List <int> l = (List<int>)s.ArraysIntersection(a, b, c);
    //     foreach (int i in l) Console.WriteLine(i);

    // }

}