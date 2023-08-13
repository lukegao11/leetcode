/*
 * @lc app=leetcode id=295 lang=csharp
 *
 * [295] Find Median from Data Stream
 */

// @lc code=start
public class MedianFinder
{
    // Create a max-heap for the left half of elements, where we store the smaller values
    PriorityQueue<int, int> max = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
    
    // Create a min-heap for the right half of elements, where we store the larger values
    PriorityQueue<int, int> min = new PriorityQueue<int, int>();

    public void AddNum(int num)
    {
        // Enqueue the new number to the max-heap
        max.Enqueue(num, num);
        
        // Enqueue the largest element from the max-heap to the min-heap, effectively balancing
        // and maintaining the order of elements between the two heaps
        min.Enqueue(max.Peek(), max.Dequeue());
        
        // Rebalance the heaps if the max-heap has fewer elements than the min-heap
        if (max.Count < min.Count)
            max.Enqueue(min.Peek(), min.Dequeue());
    }

    public double FindMedian() => min.Count != max.Count
        ? max.Peek() : (min.Peek() + max.Peek()) / 2.0; // Calculate and return the median, notice that 2.0 not 2
}
/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
// @lc code=end
