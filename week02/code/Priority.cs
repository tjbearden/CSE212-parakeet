/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
        // Expected Result: Item added
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item1",7);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
        // Expected Result: Item1 removed 
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Item2", 4);
        Console.WriteLine($"{priorityQueue.Dequeue()} has been removed from the list.");
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
        // Test 3
        // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the queue will be removed and its value returned.

        Console.WriteLine("---------");

        // Test 4
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: 
        Console.WriteLine("Test 4");


        Console.WriteLine("---------");
    }
}       